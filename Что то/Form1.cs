using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// В 1 текстбоксе записано что-то, заполить остальные


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        class Graph
        {
            struct Vertex
            {
                int Data;
                public Vertex(int NewDataValue)
                {
                    Data = NewDataValue;
                }

                public int getData() 
                {
                    return this.Data;
                }

                public void setData(int NewDataValue)
                {
                    this.Data = NewDataValue;
                }
            }

            struct Edge
            {
                int Data;
                Vertex TransmiterVertex, ReceiverVertex;
                Edge(int NewDataValue)
                {
                    this.Data = NewDataValue;
                    this.TransmiterVertex = null;
                    this.ReceiverVertex =  null;
                }
                Edge(Vertex NewTransmiterVertex, Vertex NewReceiverVertex)
                {
                    this.Data = null;
                    this.TransmiterVertex = NewTransmiterVertex;
                    this.ReceiverVertex = NewReceiverVertex;
                }
                Edge(int NewDataValue, Vertex NewTransmiterVertex, Vertex NewReceiverVertex)
                {
                    this.Data = NewDataValue;
                    this.TransmiterVertex = NewTransmiterVertex;
                    this.ReceiverVertex = NewReceiverVertex;
                }
               int getData()
                {
                    return this.Data;
                }

                void setData(int NewDataValue)
                {
                    this.Data = NewDataValue;
                }

                Vertex getTransmiterVertex()
                {
                    return this.TransmiterVertex;
                }
                void setTransmiterVertex(Vertex NewTransmiterVertex)
                {
                    this.TransmiterVertex = NewTransmiterVertex;
                }

                Vertex getReceiverVertex()
                {
                    return this.ReceiverVertex;
                }
                void setReceiverVertex(Vertex NewReceiverVertex)
                {
                    this.ReceiverVertex = NewReceiverVertex;
                }

            }

            private List<Vertex> VertexList = null; //Список Вершин
            private List<Edge> EdgeList = null; // Список ребер

            private int[,] MatrixOfVertexes = null; //Вершины
            private int[,] MatrixOfEdges = null; //Ребра
            private int[,] MatrixOfVertexesAndEdges = null; // оба

            void addVertexToList(Vertex VertexToAdd)
            {
                VertexList.Add(VertexToAdd);
            }

            Vertex getVertexFromLList(int DataToFind)
            {
                foreach(Vertex Vert in VertexList)
                {
                    if (Vert.getData() == DataToFind)
                    {
                        return Vert;
                    }
                }
                return (new Vertex(-100));
            }
            
            void deleteVertexFromList(int DataToDelete)
            {
                foreach(Vertex Vert in VertexList)
                {
                    if (Vert.getData() == DataToDelete)
                    {
                        VertexList.Remove(Vert);
                    }
                }
            }

        }
      
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void IfText1()
        {

        }
        private void IfText2()
        {

        }
        private void IfText3()
        {

        }
        private void IfText4()
        {

        }

        private void RegenButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "") IfText1();
            if (richTextBox2.Text != "") IfText2();
            if (richTextBox3.Text != "") IfText3();
            if (richTextBox4.Text != "") IfText4();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
