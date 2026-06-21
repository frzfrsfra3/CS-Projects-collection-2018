C# Projects Collection (Cleaned & Restructured)

Below is a proposed clean project structure with all student‑name‑related folders removed, followed by the Program.cs code for each remaining project.
Recommended Directory Layout
text

CSharpProjects/
├── circlearound_orbit/
│   └── Program.cs
├── circles/
│   └── Program.cs
├── ConsoleApplication1/
│   └── Program.cs
├── ConsoleApplication2/
│   └── Program.cs
├── ConsoleApplication3/
│   └── Program.cs
├── develop_outer_files/
│   └── Program.cs
├── distinctfile/
│   └── Program.cs
├── Draw_1/
│   └── Program.cs
├── hindu_1_open_gl/
│   └── Program.cs
├── megefiles/
│   └── Program.cs
├── Mhd_feras_ze_transformation/
│   └── Program.cs
├── nenene/
│   └── Program.cs
├── Robot_SharpGL/
│   └── Program.cs
├── SharpGLWinformsApplication1/
│   └── Program.cs
├── SharpGLWinformsApplication3/
│   └── Program.cs
├── techdump/
│   └── Program.cs
├── texture_box/
│   └── Program.cs
├── win_fero/
│   └── Program.cs
├── WindowsFormsApplication1/
│   └── Program.cs
├── WindowsFormsApplication2/
│   └── Program.cs
├── WindowsFormsApplication3/
│   └── Program.cs
└── WindowsFormsApplication4/
    └── Program.cs

Project Code (Program.cs)
1. circlearound_orbit
csharp

using System;
using System.Windows.Forms;

namespace circlearound_orbit
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

2. circles
csharp

using System;
using System.Windows.Forms;

namespace circles
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

3. ConsoleApplication1 – Caesar Cipher
csharp

using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string message = Console.ReadLine();
            string temp = "";
            int key = int.Parse(Console.ReadLine());
            for (int i = 0; i < message.Length; i++)
            {
                temp += a[(message[i] - 'a' + key) % a.Length];
            }
            Console.WriteLine(temp);
            string recieveddata = "";
            for (int i = 0; i < temp.Length; i++)
            {
                recieveddata += a[(((temp[i] - 'a' - key) % a.Length) + a.Length) % a.Length];
            }
            Console.WriteLine(recieveddata);
        }
    }
}

4. ConsoleApplication2 – Placeholder
csharp

using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public void linesimple(int x0, int y0, int x1, int y1, ConsoleColor Color)
        {
        }
    }
}

5. ConsoleApplication3 – OpenGL Circle Points (Tao/FreeGlut)
csharp

using System;
using Tao;
using Tao.OpenGl;
using Tao.FreeGlut;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace ConsoleApplication3
{
    class Program
    {
        private static int width = 1200, height = 720;

        static void Main(string[] args)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            Glut.glutInitWindowSize(width, height);
            Glut.glutCreateWindow("open gl tutorial");
            Glut.glutIdleFunc(OnRanderFrame);
            Glut.glutDisplayFunc(OnDisplay);
            Glut.glutReshapeFunc(OnReshapeScreen);
            Glut.glutMainLoop();
        }

        private static void OnDisplay() { }

        private static void OnRanderFrame()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glBegin(Gl.GL_POINTS);
            float angle1;
            for (angle1 = 0f; angle1 <= (2f * 3.14f); angle1 += 0.1f)
            {
                float x = (float)Math.Cos(angle1);
                float y = (float)Math.Sin(angle1);
            }
            Glut.glutSwapBuffers();
        }

        private static void OnReshapeScreen(int width, int height)
        {
            Gl.glViewport(0, 0, width, height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Glu.gluPerspective(45, width / (double)height, 0.1, 100);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glEnable(Gl.GL_DEPTH_TEST);
        }
    }
}

6. develop_outer_files – File Reader
csharp

using System;
using System.IO;

namespace Lesson12_03
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader fileReader = new StreamReader("data.txt"))
            {
                while (!fileReader.EndOfStream)
                {
                    string line = fileReader.ReadLine();
                    Console.WriteLine(line);
                }
            }
            Console.ReadLine();
        }
    }
}

7. distinctfile – Duplicate Line Remover
csharp

using System;
using System.Collections.Generic;
using System.IO;

namespace distinctfile
{
    class DeDuper
    {
        static void CopyLinesRemovingAllDupes(TextReader reader, TextWriter writer)
        {
            string currentLine;
            HashSet<string> previousLines = new HashSet<string>();
            while ((currentLine = reader.ReadLine()) != null)
            {
                if (previousLines.Add(currentLine))
                    writer.WriteLine(currentLine);
            }
            writer.Close();
        }

        static void Main(string[] args)
        {
            TextReader reader = File.OpenText("E:\\tank\\chinese-names\\Middle East Names\\arabsfull.txt");
            TextWriter writer = File.CreateText("E:\\tank\\chinese-names\\Middle East Names\\arabsfull_Distinct.txt");
            CopyLinesRemovingAllDupes(reader, writer);
        }
    }
}

8. Draw_1 – Drawing Application
csharp

using System;
using System.Windows.Forms;

namespace Draw_1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

9. hindu_1_open_gl – OpenTK with UI
csharp

using System;
using OpenTK;

namespace hindu_1_open_gl
{
    class Program
    {
        static void Main(string[] args)
        {
            GameWindow window = new GameWindow(500, 500);
            Frm frm = new Frm();
            frm.Show();
            L8 gm = new L8(window);
        }
    }
}

10. megefiles – Multi‑File Merger
csharp

using System;
using System.IO;

namespace megefiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file1 = File.ReadAllLines("E:\\tank\\chinese-names\\ferasnamesAllSummaryDistinct.txt");
            string[] file2 = File.ReadAllLines("E:\\tank\\chinese-names\\dict_arabicnames_male.txt");
            string[] file3 = File.ReadAllLines("E:\\tank\\chinese-names\\dict_arabicnames_female.txt");
            string[] file4 = File.ReadAllLines("E:\\tank\\chinese-names\\usenet-names");
            string[] file5 = File.ReadAllLines("E:\\tank\\chinese-names\\actor-givenname");
            string[] file6 = File.ReadAllLines("E:\\tank\\chinese-names\\actor-names");
            string[] file7 = File.ReadAllLines("E:\\tank\\chinese-names\\actor-surname");
            string[] file8 = File.ReadAllLines("E:\\tank\\chinese-names\\chinese-names");
            string[] file9 = File.ReadAllLines("E:\\tank\\chinese-names\\cis-givenname");
            string[] file10 = File.ReadAllLines("E:\\tank\\chinese-names\\cis-surname");
            string[] file11 = File.ReadAllLines("E:\\tank\\chinese-names\\common-names");
            string[] file12 = File.ReadAllLines("E:\\tank\\chinese-names\\congress");
            string[] file13 = File.ReadAllLines("E:\\tank\\chinese-names\\crl-name");
            string[] file14 = File.ReadAllLines("E:\\tank\\chinese-names\\family-names");
            string[] file15 = File.ReadAllLines("E:\\tank\\chinese-names\\famous");
            string[] file16 = File.ReadAllLines("E:\\tank\\chinese-names\\female-names");
            string[] file17 = File.ReadAllLines("E:\\tank\\chinese-names\\finish-firstnames");
            string[] file18 = File.ReadAllLines("E:\\tank\\chinese-names\\french-names");
            string[] file19 = File.ReadAllLines("E:\\tank\\chinese-names\\german-names");
            string[] file20 = File.ReadAllLines("E:\\tank\\chinese-names\\given-names");
            string[] file21 = File.ReadAllLines("E:\\tank\\chinese-names\\hindu-names");
            string[] file22 = File.ReadAllLines("E:\\tank\\chinese-names\\male-names");
            string[] file23 = File.ReadAllLines("E:\\tank\\chinese-names\\movie-characters");
            string[] file24 = File.ReadAllLines("E:\\tank\\chinese-names\\names.hp");
            string[] file25 = File.ReadAllLines("E:\\tank\\chinese-names\\norwegian-names");
            string[] file26 = File.ReadAllLines("E:\\tank\\chinese-names\\other-names");
            string[] file27 = File.ReadAllLines("E:\\tank\\chinese-names\\shakespeare-names");
            string[] file28 = File.ReadAllLines("E:\\tank\\chinese-names\\surnames");
            string[] file29 = File.ReadAllLines("E:\\tank\\chinese-names\\swedish-names");

            using (StreamWriter writer = File.CreateText(@"E:\tank\chinese-names\MaximumXXXOptions.txt"))
            {
                int lineNum = 0;
                while (lineNum < file1.Length || lineNum < file2.Length || lineNum < file3.Length ||
                       lineNum < file4.Length || lineNum < file5.Length || lineNum < file6.Length ||
                       lineNum < file7.Length || lineNum < file8.Length || lineNum < file9.Length ||
                       lineNum < file10.Length || lineNum < file11.Length || lineNum < file12.Length ||
                       lineNum < file13.Length || lineNum < file14.Length || lineNum < file15.Length ||
                       lineNum < file16.Length || lineNum < file17.Length || lineNum < file18.Length ||
                       lineNum < file19.Length || lineNum < file20.Length || lineNum < file21.Length ||
                       lineNum < file22.Length || lineNum < file23.Length || lineNum < file24.Length ||
                       lineNum < file25.Length || lineNum < file26.Length || lineNum < file27.Length ||
                       lineNum < file28.Length || lineNum < file29.Length)
                {
                    if (lineNum < file1.Length) writer.WriteLine(file1[lineNum]);
                    if (lineNum < file2.Length) writer.WriteLine(file2[lineNum]);
                    if (lineNum < file3.Length) writer.WriteLine(file3[lineNum]);
                    if (lineNum < file4.Length) writer.WriteLine(file4[lineNum]);
                    if (lineNum < file5.Length) writer.WriteLine(file5[lineNum]);
                    if (lineNum < file6.Length) writer.WriteLine(file6[lineNum]);
                    if (lineNum < file7.Length) writer.WriteLine(file7[lineNum]);
                    if (lineNum < file8.Length) writer.WriteLine(file8[lineNum]);
                    if (lineNum < file9.Length) writer.WriteLine(file9[lineNum]);
                    if (lineNum < file10.Length) writer.WriteLine(file10[lineNum]);
                    if (lineNum < file11.Length) writer.WriteLine(file11[lineNum]);
                    if (lineNum < file12.Length) writer.WriteLine(file12[lineNum]);
                    if (lineNum < file13.Length) writer.WriteLine(file13[lineNum]);
                    if (lineNum < file14.Length) writer.WriteLine(file14[lineNum]);
                    if (lineNum < file15.Length) writer.WriteLine(file15[lineNum]);
                    if (lineNum < file16.Length) writer.WriteLine(file16[lineNum]);
                    if (lineNum < file17.Length) writer.WriteLine(file17[lineNum]);
                    if (lineNum < file18.Length) writer.WriteLine(file18[lineNum]);
                    if (lineNum < file19.Length) writer.WriteLine(file19[lineNum]);
                    if (lineNum < file20.Length) writer.WriteLine(file20[lineNum]);
                    if (lineNum < file21.Length) writer.WriteLine(file21[lineNum]);
                    if (lineNum < file22.Length) writer.WriteLine(file22[lineNum]);
                    if (lineNum < file23.Length) writer.WriteLine(file23[lineNum]);
                    if (lineNum < file24.Length) writer.WriteLine(file24[lineNum]);
                    if (lineNum < file25.Length) writer.WriteLine(file25[lineNum]);
                    if (lineNum < file26.Length) writer.WriteLine(file26[lineNum]);
                    if (lineNum < file27.Length) writer.WriteLine(file27[lineNum]);
                    if (lineNum < file28.Length) writer.WriteLine(file28[lineNum]);
                    if (lineNum < file29.Length) writer.WriteLine(file29[lineNum]);

                    lineNum++;
                }
            }
        }
    }
}

11. Mhd_feras_ze_transformation – WinForms
csharp

using System;
using System.Windows.Forms;

namespace Mhd_feras_ze_transformation
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

12. nenene – Number Generator
csharp

using System.IO;

namespace nenene
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("e:\\Tank\\6num");
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    for (int k = 0; k < 10; k++)
                        for (int l = 0; l < 10; l++)
                            for (int m = 0; m < 10; m++)
                                for (int n = 0; n < 10; n++)
                                    sw.WriteLine(i + "" + j + "" + k + "" + l + "" + m + "" + n);
        }
    }
}

13. Robot_SharpGL
csharp

using System;
using System.Windows.Forms;

namespace SharpGLWinformsApplication2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SharpGLForm());
        }
    }
}

14. SharpGLWinformsApplication1
csharp

using System;
using System.Windows.Forms;

namespace SharpGLWinformsApplication1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SharpGLForm());
        }
    }
}

15. SharpGLWinformsApplication3
csharp

using System;
using System.Windows.Forms;

namespace SharpGLWinformsApplication3
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SharpGLForm());
        }
    }
}

16. techdump
csharp

using System;
using System.Windows.Forms;

namespace techdump
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            new MainWindow().Run(60);
        }
    }
}

17. texture_box – OpenTK
csharp

using System;
using OpenTK;

namespace hindu_1_open_gl
{
    class Program
    {
        static void Main(string[] args)
        {
            GameWindow window = new GameWindow(500, 500);
            L8 gm = new L8(window);
        }
    }
}

18. win_fero
csharp

using System;
using System.Windows.Forms;

namespace win_fero
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

19. WindowsFormsApplication1
csharp

using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

20. WindowsFormsApplication2
csharp

using System;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

21. WindowsFormsApplication3
csharp

using System;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

22. WindowsFormsApplication4
csharp

using System;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

    Note: This selection excludes student‑specific duplicates and personal folders. All projects retain their original namespace and logic; only the surrounding directory names are suggested for a cleaner repository.
