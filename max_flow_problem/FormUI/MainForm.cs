using Microsoft.Glee.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FormUI
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        int[,] graphArr;
        List<Edge> edgeList;
        List<List<Edge>> maxLists;
        List<Graph> graphs;
        Graph graph;
        Random rnd = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        public struct Edge
        {
            public int x, y, i;
        }

        public void addEdge(int x, int y, int i)
        {
            Edge edge = new Edge();
            edge.x = x; edge.y = y; edge.i = i;
            edgeList.Add(edge);
        }

        private void readfileBtn_Click(object sender, EventArgs e)
        {
            ofd.FileName = "";
            ofd.Filter = "Text documents (*.txt) | *.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                graphRb.Checked = true;
                graph = new Graph("graph");
                fileTb.Clear();
                resTb.Clear();
                string fileArr;
                fileLbl.Text = ofd.SafeFileName;
                fileArr = File.ReadAllText(ofd.FileName);
                int size = fileArr.Split('\n').Length;
                graphArr = new int[size, size];
                int i = 0, j = 0;
                foreach (var row in fileArr.Split('\n'))
                {
                    j = 0;
                    foreach (var col in row.Trim().Split(' '))
                    {
                        graphArr[i, j] = int.Parse(col.Trim());
                        j++;
                    }
                    i++;
                }
                foreach (var row in fileArr.Split('\n'))
                {
                    string strrow = row.Trim();
                    fileTb.AppendText(strrow + Environment.NewLine);
                }

                int n = graphArr.GetLength(0);

                edgeList = new List<Edge>();
                /*
                for (i = 0; i < n; i++)
                {
                    for (j = i + 1; j < n; j++)
                    {
                        if (graphArr[i, j] != 0)
                        {
                            addEdge(i, j, graphArr[i, j]);
                        }
                    }
                }
                */
                for (i = 0; i < n; i++)
                {
                    if (i == 0)
                        j = i + 1;
                    else
                        j = 0;
                    for (; j < n; j++)
                    {
                        if (graphArr[i, j] != 0)
                        {
                            addEdge(i, j, graphArr[i, j]);
                        }
                    }
                }
                resTb.AppendText("Node and max. size: (x, y) : i" + Environment.NewLine);
                foreach (Edge edge in edgeList)
                {
                    graph.AddEdge(edge.x.ToString(), edge.i.ToString(), edge.y.ToString());
                    string str = "(" + edge.x + ", " + edge.y + ") : " + edge.i;
                    resTb.AppendText(str + Environment.NewLine);
                }

                foreach (var edge in graph.Edges)
                    edge.Attr.LineWidth = 2;

                graph.GraphAttr.Orientation = Microsoft.Glee.Drawing.Orientation.Landscape;
                graph.GraphAttr.LayerDirection = LayerDirection.LR;
                graphViewer.OutsideAreaBrush = Brushes.White;
                graphViewer.Graph = graph;

                resTb.AppendText(Environment.NewLine);
            }
        }

        public class MaxFlow
        {
            public int V;
            List<List<MainForm.Edge>> maxLists = new List<List<MainForm.Edge>>();
            internal bool bfs(int[,] rgraph, int s, int t, int[] parent)
            {
                bool[] visited = new bool[V];
                for (int i = 0; i < V; ++i)
                    visited[i] = false;
                Queue<int> queue = new Queue<int>();
                queue.Enqueue(s);
                visited[s] = true;
                parent[s] = -1;

                while (queue.Count != 0)
                {
                    int u = queue.Dequeue();

                    for (int i = 0; i < V; i++)
                    {
                        if (visited[i] == false && rgraph[u, i] > 0)
                        {
                            queue.Enqueue(i);
                            parent[i] = u;
                            visited[i] = true;
                        }
                    }
                }

                return (visited[t] == true);
            }

            public List<List<MainForm.Edge>> GetMax()
            {
                return maxLists;
            }

            internal int fordFulkerson(int[,] graph, int v, int s, int t, RichTextBox tb)
            {
                Stack<int> path = new Stack<int>();
                List<int> path2 = new List<int>();
                V = v;
                int x, y;
                int[,] rGraph = new int[V, V];
                for (x = 0; x < V; x++)
                    for (y = 0; y < V; y++)
                        rGraph[x, y] = graph[x, y];

                int[] parent = new int[V];

                int max_flow = 0;

                tb.AppendText("Chains: " + Environment.NewLine);
                int chain = 0;
                while (bfs(rGraph, s, t, parent))
                {
                    List<MainForm.Edge> maxEdges = new List<MainForm.Edge>();
                    int path_flow = int.MaxValue;
                    path.Push(t);
                    for (y = t; y != s; y = parent[y])
                    {
                        x = parent[y];
                        path_flow = Math.Min(path_flow, rGraph[x, y]);
                        path.Push(x);
                    }

                    for (y = t; y != s; y = parent[y])
                    {
                        x = parent[y];
                        rGraph[x, y] -= path_flow;
                        rGraph[y, x] += path_flow;
                    }
                    tb.AppendText("[" + chain + "]: ");
                    foreach (int i in path)
                    {
                        path2.Add(i);
                        tb.AppendText(i + " ");
                    }

                    for (int i = 0; i < path2.Count - 1; i++)
                    {
                        MainForm.Edge edge = new MainForm.Edge();
                        edge.x = path2[i]; edge.y = path2[i + 1]; edge.i = graph[i, i + 1];
                        maxEdges.Add(edge);
                    }

                    tb.AppendText(": " + path_flow + Environment.NewLine);
                    maxLists.Add(maxEdges);
                    path.Clear();
                    path2.Clear();
                    max_flow += path_flow;
                    chain++;
                }
                return max_flow;
            }
        }

        private void maxFlowBtn_Click(object sender, EventArgs e)
        {
            MaxFlow m = new MaxFlow();
            int start = Int16.Parse(startVertexTb.Text);
            int end = Int16.Parse(endVertexTb.Text);
            resTb.AppendText("Max. flow: " + m.fordFulkerson(graphArr, graphArr.GetLength(0), 
                start, end, resTb) + Environment.NewLine);
            routeCb.Items.Clear();
            graphrbMp.Enabled = true;
            graphRb.Checked = true;
            maxLists = m.GetMax();
            graphs = new List<Graph>();
            for (int i = 0; i < maxLists.Count; i++)
            {
                Graph graph = new Graph(i.ToString());
                foreach (Edge edge in edgeList)
                    graph.AddEdge(edge.x.ToString(), edge.i.ToString(), edge.y.ToString());

                foreach (var edge in graph.Edges)
                    edge.Attr.LineWidth = 2;

                graph.GraphAttr.Orientation = Microsoft.Glee.Drawing.Orientation.Landscape;
                graph.GraphAttr.LayerDirection = LayerDirection.LR;
                graphViewer.OutsideAreaBrush = Brushes.White;
                graphs.Add(graph);
                routeCb.Items.Add(i);
            }
        }

        private void graphRb_CheckedChanged(object sender, EventArgs e)
        {
            if (graphRb.Checked)
            {
                routeCb.Visible = false;
                foreach (var edge in graph.Edges)
                {
                    edge.Attr.Color = Microsoft.Glee.Drawing.Color.Black;
                    edge.TargetNode.Attr.Color = Microsoft.Glee.Drawing.Color.Black;
                    edge.SourceNode.Attr.Color = Microsoft.Glee.Drawing.Color.Black;
                    edge.Attr.Fontcolor = Microsoft.Glee.Drawing.Color.Black;
                }
                graphViewer.Graph = graph;
                graphViewer.Refresh();
            }
        }

        Microsoft.Glee.Drawing.Color ChangeColor(int i)
        {
            Microsoft.Glee.Drawing.Color rndColor = new Microsoft.Glee.Drawing.Color();
            switch (i)
            {
                case 0:
                    rndColor = Microsoft.Glee.Drawing.Color.Red;
                    return rndColor;
                case 1:
                    rndColor = Microsoft.Glee.Drawing.Color.Blue;
                    return rndColor;
                case 2:
                    rndColor = Microsoft.Glee.Drawing.Color.Green;
                    return rndColor;
                case 3:
                    rndColor = Microsoft.Glee.Drawing.Color.Yellow;
                    return rndColor;
                case 4:
                    rndColor = Microsoft.Glee.Drawing.Color.Magenta;
                    return rndColor;
                case 5:
                    rndColor = Microsoft.Glee.Drawing.Color.Purple;
                    return rndColor;
                case 6:
                    rndColor = Microsoft.Glee.Drawing.Color.Brown;
                    return rndColor;
                case 7:
                    rndColor = Microsoft.Glee.Drawing.Color.Cyan;
                    return rndColor;
                case 8:
                    rndColor = Microsoft.Glee.Drawing.Color.Orange;
                    return rndColor;
                case 9:
                    rndColor = Microsoft.Glee.Drawing.Color.Violet;
                    return rndColor;
            }
            return rndColor;
        }

        private void graph_maxRb_CheckedChanged(object sender, EventArgs e)
        {
            if (graph_maxRb.Checked)
            {
                int i = 0;
                Microsoft.Glee.Drawing.Color rndColor = new Microsoft.Glee.Drawing.Color();
                foreach (var edge in graph.Edges)
                {
                    edge.Attr.Color = Microsoft.Glee.Drawing.Color.Black;
                    edge.TargetNode.Attr.Color = Microsoft.Glee.Drawing.Color.Black;
                    edge.SourceNode.Attr.Color = Microsoft.Glee.Drawing.Color.Black;
                    edge.Attr.Fontcolor = Microsoft.Glee.Drawing.Color.Black;
                }

                if (maxLists.Count > 0)
                {
                    foreach (var maxEdges in maxLists)
                    {
                        rndColor = ChangeColor(i);
                        foreach (var edge in graphs[i].Edges)
                        {
                            foreach (var max_e in maxEdges)
                            {
                                if ((edge.Source == max_e.x.ToString() && edge.Target == max_e.y.ToString()) 
                                    || (edge.Source == max_e.x.ToString() && edge.Target == max_e.y.ToString()))
                                {
                                    edge.Attr.Color = rndColor;
                                    edge.Attr.Fontcolor = rndColor;
                                    edge.TargetNode.Attr.Color = rndColor;
                                    edge.SourceNode.Attr.Color = rndColor;
                                }
                            }
                        }
                        i++;
                        if (i > 9)
                            i = 0;
                    }

                }
                routeCb.Visible = true;
                routeCb.SelectedIndex = 0;
                graphViewer.Refresh();
            }

        }

        private void routeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            graphViewer.Graph = graphs[routeCb.SelectedIndex];
            graphViewer.Refresh();
        }
    }
}
