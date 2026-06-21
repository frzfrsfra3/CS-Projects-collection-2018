
=== FILTERED TREE ===

[DIR] D:\posso\Projects\Projects\circlearound orbit\circlearound orbit
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\circles\circles
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\ConsoleApplication1\ConsoleApplication1
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\ConsoleApplication2\ConsoleApplication2
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\ConsoleApplication3\ConsoleApplication3
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\develop_outer_files\develop_outer_files
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\distinctfile\distinctfile
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\Draw 1\Draw 1
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\hindu 1 open gl\hindu 1 open gl
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\megefiles\megefiles
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\Mhd feras ze transformation\Mhd feras ze transformation
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\nenene\nenene
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\Robot\SharpGLWinformsApplication2
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\SharpGLWinformsApplication1\SharpGLWinformsApplication1
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\SharpGLWinformsApplication3\SharpGLWinformsApplication3
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\techdump\techdump
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\texture box\texture box
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\win fero\win fero
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\WindowsFormsApplication1\WindowsFormsApplication1
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\WindowsFormsApplication2\WindowsFormsApplication2
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\WindowsFormsApplication3\WindowsFormsApplication3
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\WindowsFormsApplication4\WindowsFormsApplication4
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\محمد فراس زعيتر\محمد فراس زعيتر
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\محمد فراس زعيتر\Draw 1\Draw 1
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\محمد فراس زعيتر مشاريع\Draw 1\Draw 1
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\محمد فراس زعيتر مشاريع\OpenTK\1.1\Source\Build.UpdateVersion
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\محمد فراس زعيتر مشاريع\OpenTK\1.1\Source\Generator.Rewrite
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\محمد فراس زعيتر مشاريع\OpenTK\1.1\Source\OpenTK\Compute
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\محمد فراس زعيتر مشاريع\Robot\SharpGLWinformsApplication2
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\محمد فراس زعيتر\circle algorithm\circle algorithm
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\محمد فراس زعيتر\texture 3d with control open gl c#\hindu 1 open gl\hindu 1 open gl
  |-- Program.cs

[DIR] D:\posso\Projects\Projects\محمد فراس زعيتر\texture box\texture box\texture box
  |-- Program.cs

=== FILE CONTENT ===

===== D:\posso\Projects\Projects\circlearound orbit\circlearound orbit\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
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

===== D:\posso\Projects\Projects\circles\circles\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
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

===== D:\posso\Projects\Projects\ConsoleApplication1\ConsoleApplication1\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                temp += a[(message[i] -'a' + key) % a.Length];
            }
            Console.WriteLine(temp);
            string recieveddata = "";
            for (int i = 0; i < temp.Length; i++)
            {
             recieveddata+=a[(((temp[i] -'a' - key)%a.Length )+a.Length)%a.Length];   
            }
            Console.WriteLine(recieveddata);
        }
    }
}

===== D:\posso\Projects\Projects\ConsoleApplication2\ConsoleApplication2\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

===== D:\posso\Projects\Projects\ConsoleApplication3\ConsoleApplication3\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        private static void OnDisplay()
        {
        }
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
        private static void OnReshapeScreen(int width,int height)
        {
            Gl.glViewport(0, 0, width, height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Glu.gluPerspective(45, width / (double)height, 0.1, 100);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glEnable(Gl.GL_DEPTH_TEST);
        }
    }
}

===== D:\posso\Projects\Projects\develop_outer_files\develop_outer_files\Program.cs =====
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
	                while(!fileReader.EndOfStream)
	                {
	                    string line = fileReader.ReadLine();
	                    Console.WriteLine(line);
	                }
	            }
                Console.ReadLine();
	        }
	    }
	}

===== D:\posso\Projects\Projects\distinctfile\distinctfile\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                {
                    writer.WriteLine(currentLine);
                }
            }
            writer.Close();
        }
        static void Main(string[] args)
        {
            TextReader reader = File.OpenText("E:\\tank\\chinese-names\\Middle East Names\\arabsfull.txt");
            TextWriter writer = File.CreateText("E:\\tank\\chinese-names\\Middle East Names\\arabsfull_Distinct.txt");
            CopyLinesRemovingAllDupes(reader,writer);
        }
    }
}

===== D:\posso\Projects\Projects\Draw 1\Draw 1\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
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

===== D:\posso\Projects\Projects\hindu 1 open gl\hindu 1 open gl\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;
namespace hindu_1_open_gl
{
    class Program
    {
        static void Main(string[] args)
        {
            GameWindow window = new GameWindow(500,500);
            Frm frm = new Frm();
            frm.Show();
            L8 gm = new L8(window);
        }
    }
}

===== D:\posso\Projects\Projects\megefiles\megefiles\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using (StreamWriter writer = File.CreateText(@"E:\\tank\\chinese-names\\MaximumXXXOptions.txt"))
{
    int lineNum = 0;
    while (lineNum < file1.Length || lineNum < file2.Length || lineNum < file3.Length || lineNum < file4.Length || lineNum < file5.Length || lineNum < file6.Length || lineNum < file7.Length || lineNum < file8.Length || lineNum < file9.Length || lineNum < file10.Length || lineNum < file11.Length || lineNum < file12.Length || lineNum < file13.Length || lineNum < file14.Length || lineNum < file15.Length || lineNum < file16.Length || lineNum < file17.Length || lineNum < file18.Length || lineNum < file19.Length || lineNum < file20.Length || lineNum < file21.Length || lineNum < file22.Length || lineNum < file23.Length || lineNum < file24.Length || lineNum < file25.Length || lineNum < file26.Length || lineNum < file27.Length || lineNum < file28.Length || lineNum < file29.Length )
    {
        if(lineNum < file1.Length)
            writer.WriteLine(file1[lineNum]);
        if(lineNum < file2.Length)
            writer.WriteLine(file2[lineNum]);
        if (lineNum < file3.Length)
            writer.WriteLine(file3[lineNum]);
        if (lineNum < file4.Length)
            writer.WriteLine(file4[lineNum]);
        if (lineNum < file5.Length)
            writer.WriteLine(file5[lineNum]);
        if (lineNum < file6.Length)
            writer.WriteLine(file6[lineNum]);
        if (lineNum < file7.Length)
            writer.WriteLine(file7[lineNum]);
        if (lineNum < file8.Length)
            writer.WriteLine(file8[lineNum]);
        if (lineNum < file9.Length)
            writer.WriteLine(file9[lineNum]);
        if (lineNum < file10.Length)
            writer.WriteLine(file10[lineNum]);
        if (lineNum < file11.Length)
            writer.WriteLine(file11[lineNum]);
        if (lineNum < file12.Length)
            writer.WriteLine(file12[lineNum]);
        if (lineNum < file13.Length)
            writer.WriteLine(file13[lineNum]);
        if (lineNum < file14.Length)
            writer.WriteLine(file14[lineNum]);
        if (lineNum < file15.Length)
            writer.WriteLine(file15[lineNum]);
        if (lineNum < file16.Length)
            writer.WriteLine(file16[lineNum]);
        if (lineNum < file17.Length)
            writer.WriteLine(file17[lineNum]);
        if (lineNum < file18.Length)
            writer.WriteLine(file18[lineNum]);
        if (lineNum < file19.Length)
            writer.WriteLine(file19[lineNum]);
        if (lineNum < file20.Length)
            writer.WriteLine(file20[lineNum]);
        if (lineNum < file21.Length)
            writer.WriteLine(file21[lineNum]);
        if (lineNum < file22.Length)
            writer.WriteLine(file22[lineNum]);
        if (lineNum < file23.Length)
            writer.WriteLine(file23[lineNum]);
        if (lineNum < file24.Length)
            writer.WriteLine(file24[lineNum]);
        if (lineNum < file25.Length)
            writer.WriteLine(file25[lineNum]);
        if (lineNum < file26.Length)
            writer.WriteLine(file26[lineNum]);
        if (lineNum < file27.Length)
            writer.WriteLine(file27[lineNum]);
        if (lineNum < file28.Length)
            writer.WriteLine(file28[lineNum]);
        if (lineNum < file29.Length)
            writer.WriteLine(file29[lineNum]);
        lineNum++;
    }
}
        }
    }
}

===== D:\posso\Projects\Projects\Mhd feras ze transformation\Mhd feras ze transformation\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
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

===== D:\posso\Projects\Projects\nenene\nenene\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace nenene
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("e:\\Tank\\6num");
            for (int i=0;i<10;i++)
                 for (int j=0;j<10;j++)
                      for (int k=0;k<10;k++)
                           for (int l=0;l<10;l++)
                                for (int m=0;m<10;m++)
                                    for (int n = 0; n < 10; n++)
                                    {
                                        sw.WriteLine(i+""+j+""+k+""+l+""+m+""+n);
                                    }
        }
    }
}

===== D:\posso\Projects\Projects\Robot\SharpGLWinformsApplication2\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
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

===== D:\posso\Projects\Projects\SharpGLWinformsApplication1\SharpGLWinformsApplication1\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
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

===== D:\posso\Projects\Projects\SharpGLWinformsApplication3\SharpGLWinformsApplication3\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
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

===== D:\posso\Projects\Projects\techdump\techdump\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
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

===== D:\posso\Projects\Projects\texture box\texture box\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

===== D:\posso\Projects\Projects\win fero\win fero\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
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

===== D:\posso\Projects\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
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

===== D:\posso\Projects\Projects\WindowsFormsApplication2\WindowsFormsApplication2\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
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

===== D:\posso\Projects\Projects\WindowsFormsApplication3\WindowsFormsApplication3\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
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

===== D:\posso\Projects\Projects\WindowsFormsApplication4\WindowsFormsApplication4\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
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

===== D:\posso\Projects\Projects\محمد فراس زعيتر\محمد فراس زعيتر\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace sami_abd_alghani
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

===== D:\posso\Projects\Projects\محمد فراس زعيتر\Draw 1\Draw 1\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
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

===== D:\posso\Projects\Projects\محمد فراس زعيتر\circle algorithm\circle algorithm\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace circle_algorithm
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

===== D:\posso\Projects\Projects\محمد فراس زعيتر\texture 3d with control open gl c#\hindu 1 open gl\hindu 1 open gl\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;
namespace hindu_1_open_gl
{
    class Program
    {
        static void Main(string[] args)
        {
            GameWindow window = new GameWindow(500,500);
            Frm frm = new Frm();
            frm.Show();
            L8 gm = new L8(window);
        }
    }
}

===== D:\posso\Projects\Projects\محمد فراس زعيتر\texture box\texture box\texture box\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

===== D:\posso\Projects\Projects\محمد فراس زعيتر مشاريع\Draw 1\Draw 1\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
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

===== D:\posso\Projects\Projects\محمد فراس زعيتر مشاريع\OpenTK\1.1\Source\Build.UpdateVersion\Program.cs =====
#region License
#endregion
using System;
using System.Diagnostics;
using System.IO;
namespace Build.UpdateVersion
{
    class Program
    {
        const string Major = "1";
        const string Minor = "1";
        static string RootDirectory;
        static string SourceDirectory;
        public static void Main()
        {
            string wdir = Environment.CurrentDirectory;
            if (Directory.GetParent(wdir).Name == "Source")
            {
                RootDirectory = "../..";
                SourceDirectory = "..";
            }
            else
            {
                RootDirectory = "../../..";
                SourceDirectory = "../../../Source";
            }
            DateTime now = DateTime.UtcNow;
            string timestamp = now.ToString("u").Split(' ')[0];
            double timespan = now.Subtract(new DateTime(2010, 1, 1)).TotalDays;
            string build = ((int)timespan).ToString();
            string revision = RetrieveRevisionNumber(now);
            string major = Major;
            string minor = Minor;
            string version = String.Format("{0}.{1}.{2}.{3}", major, minor, build, revision);
            Console.WriteLine("API compatibility key: {0}.{1}", major, minor);
            Console.WriteLine("Build date: {0}", timestamp);
            GenerateTimestamp(timestamp, Path.Combine(RootDirectory, "Timestamp.txt"));
            GenerateVersion(version, Path.Combine(RootDirectory, "Version.txt"));
            GenerateAssemblyInfo(major, minor, version, Path.Combine(SourceDirectory, "GlobalAssemblyInfo.cs"));
        }
        static void GenerateTimestamp(string timestamp, string file)
        {
            System.IO.File.WriteAllLines(file, new string[] { timestamp });
        }
        static void GenerateVersion(string version, string file)
        {
            File.WriteAllLines(file, new string[] { version });
        }
        static void GenerateAssemblyInfo(string major, string minor, string version, string file)
        {
            File.WriteAllLines(file, new string[]
            {
                "
                "
                "",
                "using System;",
                "using System.Reflection;",
                "using System.Resources;",
                "using System.Runtime.CompilerServices;",
                "using System.Runtime.InteropServices;",
                "",
                "[assembly: AssemblyCompany(\"The Open Toolkit Library\")]",
                "[assembly: AssemblyProduct(\"The Open Toolkit Library\")]",
                "[assembly: AssemblyCopyright(\"Copyright © 2006 - 2014 the Open Toolkit Library\")]",
                "[assembly: AssemblyTrademark(\"OpenTK\")]",
                String.Format("[assembly: AssemblyVersion(\"{0}.{1}.0.0\")]", major, minor),
                String.Format("[assembly: AssemblyFileVersion(\"{0}\")]", version),
            });
        }
        static string RetrieveRevisionNumber(DateTime now)
        {
            double timespan = now.Subtract(new DateTime(2010, 1, 1)).TotalDays;
            string revision = RetrieveGitRevision() ?? RetrieveSvnRevision() ?? RetrieveBzrRevision() ?? "0";
            revision = revision.Trim();
            return revision;
        }
        static string RetrieveSeconds(double timespan)
        {
            string revision = ((int)((timespan - (int)timespan) * UInt16.MaxValue)).ToString();
            return revision;
        }
        static string RetrieveGitRevision()
        {
            try
            {
                string output = RunProcess("git", "rev-list HEAD --count", RootDirectory);
                return output.Trim(' ', '\n');
            }
            catch (Exception e)
            {
                Debug.Print("Failed to retrieve git revision. Error: {0}", e);
            }
            return null;
        }
        static string RetrieveSvnRevision()
        {
            try
            {
                string output = RunProcess("svn", "info", RootDirectory);
                const string RevisionText = "Revision: ";
                int index = output.IndexOf(RevisionText);
                if (index > -1)
                    return output.Substring(index + RevisionText.Length, 5)
                        .Replace('\r', ' ').Replace('\n', ' ').Trim();
            }
            catch (Exception e)
            {
                Debug.Print("Failed to retrieve svn revision. Error: {0}", e);
            }
            return null;
        }
        static string RetrieveBzrRevision()
        {
            try
            {
                string output = RunProcess("bzr", "revno", RootDirectory);
                return output != null && !output.StartsWith("bzr") ? output : null;
            }
            catch (Exception e)
            {
                Debug.Print("Failed to retrieve svn revision. Error: {0}", e);
            }
            return null;
        }
        static string RunProcess(string cmd, string args, string wdir)
        {
            ProcessStartInfo info = new ProcessStartInfo(cmd, args);
            info.WorkingDirectory = wdir;
            info.RedirectStandardOutput = true;
            info.RedirectStandardError = true;
            info.UseShellExecute = false;
            Process p = new Process();
            p.StartInfo = info;
            p.Start();
            p.WaitForExit();
            string output = p.StandardOutput.ReadToEnd();
            return output;
        }
    }
}

===== D:\posso\Projects\Projects\محمد فراس زعيتر مشاريع\OpenTK\1.1\Source\Generator.Rewrite\Program.cs =====
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Rocks;
namespace OpenTK.Rewrite
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: rewrite [file.dll] [file.snk] [options]");
                Console.WriteLine("[options] is:");
                Console.WriteLine("    -debug (enable calls to GL.GetError())");
                return;
            }
            var program = new Program();
            var file = args[0];
            var key = args[1];
            var options = args.Where(a => a.StartsWith("-") || a.StartsWith("/"));
            program.Rewrite(file, key, options);
        }
        static AssemblyDefinition mscorlib;
        static TypeDefinition TypeMarshal;
        static TypeDefinition TypeStringArray;
        static TypeDefinition TypeStringBuilder;
        static TypeDefinition TypeVoid;
        static TypeDefinition TypeIntPtr;
        static TypeDefinition TypeInt32;
        static TypeDefinition TypeBindingsBase;
        void Rewrite(string file, string keyfile, IEnumerable<string> options)
        {
            var read_params = new ReaderParameters();
            var write_params = new WriterParameters();
            var pdb = Path.ChangeExtension(file, "pdb");
            var mdb = Path.ChangeExtension(file, "mdb");
            ISymbolReaderProvider provider = null;
            if (File.Exists(pdb))
            {
                provider = new Mono.Cecil.Pdb.PdbReaderProvider();
            }
            else if (File.Exists(mdb))
            {
                provider = new Mono.Cecil.Mdb.MdbReaderProvider();
            }
            read_params.SymbolReaderProvider = provider;
            read_params.ReadSymbols = true;
            write_params.WriteSymbols = true;
            if (!String.IsNullOrEmpty(keyfile) && File.Exists(keyfile))
            {
                keyfile = Path.GetFullPath(keyfile);
                var fs = new FileStream(keyfile, FileMode.Open);
                var keypair = new System.Reflection.StrongNameKeyPair(fs);
                fs.Close();
                write_params.StrongNameKeyPair = keypair;
            }
            else
            {
                Console.Error.WriteLine("No keyfile specified or keyfile missing.");
            }
            var assembly = AssemblyDefinition.ReadAssembly(file, read_params);
            var rewritten = assembly.CustomAttributes.FirstOrDefault(a => a.AttributeType.Name == "RewrittenAttribute");
            if (rewritten == null)
            {
                foreach (var module in assembly.Modules)
                {
                    foreach (var reference in module.AssemblyReferences)
                    {
                        var resolved = module.AssemblyResolver.Resolve(reference);
                        if (reference.Name == "mscorlib")
                        {
                            mscorlib = resolved;
                        }
                    }
                }
                if (mscorlib == null)
                {
                    Console.Error.WriteLine("Failed to locate mscorlib");
                    return;
                }
                TypeMarshal = mscorlib.MainModule.GetType("System.Runtime.InteropServices.Marshal");
                TypeStringArray = mscorlib.MainModule.GetType("System.String").MakeArrayType().Resolve();
                TypeStringBuilder = mscorlib.MainModule.GetType("System.Text.StringBuilder");
                TypeVoid = mscorlib.MainModule.GetType("System.Void");
                TypeIntPtr = mscorlib.MainModule.GetType("System.IntPtr");
                TypeInt32 = mscorlib.MainModule.GetType("System.Int32");
                TypeBindingsBase = assembly.Modules.Select(m => m.GetType("OpenTK.BindingsBase")).First();
                foreach (var module in assembly.Modules)
                {
                    foreach (var type in module.Types)
                    {
                        Rewrite(type, options);
                    }
                }
            }
            else
            {
                Console.Error.WriteLine("Error: assembly has already been rewritten");
            }
            assembly.Write(file, write_params);
        }
        void Rewrite(TypeDefinition type, IEnumerable<string> options)
        {
            var entry_points = type.Fields.FirstOrDefault(f => f.Name == "EntryPoints");
            if (entry_points != null)
            {
                var entry_signatures = new List<MethodDefinition>();
                entry_signatures.AddRange(type.Methods
                    .Where(t => t.CustomAttributes.Any(a => a.AttributeType.Name == "SlotAttribute")));
                Rewrite(type, entry_points, entry_signatures, options);
                RemoveNativeSignatures(type, entry_signatures);
            }
            if (type.Name == "RewrittenAttribute")
            {
                var rewritten_constructor = type.GetConstructors().First();
                var rewritten = new CustomAttribute(rewritten_constructor);
                rewritten.ConstructorArguments.Add(new CustomAttributeArgument(
                    type.Module.Import(mscorlib.MainModule.GetType("System.Boolean")), true));
                type.Module.Assembly.CustomAttributes.Add(rewritten);
            }
        }
        int GetSlot(MethodDefinition signature)
        {
            var slot_attribute = signature.CustomAttributes
                        .FirstOrDefault(a => a.AttributeType.Name == "SlotAttribute");
            int slot =
                slot_attribute != null ?
                (int)slot_attribute.ConstructorArguments[0].Value :
                -1;
            return slot;
        }
        void Rewrite(TypeDefinition type, FieldDefinition entry_points,
            List<MethodDefinition> entry_signatures, IEnumerable<string> options)
        {
            var wrapper_signatures = new List<MethodDefinition>();
            wrapper_signatures.AddRange(type.Methods
                .Where(m => m.IsPublic && m.CustomAttributes.Any(a => a.AttributeType.Name == "AutoGeneratedAttribute")));
            foreach (var wrapper in wrapper_signatures)
            {
                var autogenerated = wrapper.CustomAttributes
                    .Where(a => a.AttributeType.Name == "AutoGeneratedAttribute");
                if (autogenerated.Count() > 0)
                {
                    var signature_name = (string)autogenerated.First()
                        .Fields.First(f => f.Name == "EntryPoint").Argument.Value;
                    var signature = entry_signatures.FirstOrDefault(s => s.Name == signature_name);
                    int slot = GetSlot(signature);
                    ProcessMethod(wrapper, signature, slot, entry_points, options);
                }
            }
            RemoveSupportingAttributes(type);
            if (type.NestedTypes.Count > 0)
            {
                foreach (var nested_type in type.NestedTypes)
                {
                    Rewrite(nested_type, entry_points, entry_signatures, options);
                }
            }
        }
        void RemoveNativeSignatures(TypeDefinition type, List<MethodDefinition> methods)
        {
            foreach (var m in methods.Where(s => GetSlot(s) != -1))
            {
                type.Methods.Remove(m);
            }
        }
        void RemoveSupportingAttributes(TypeDefinition type)
        {
            foreach (var method in type.Methods)
            {
                var attr = method.CustomAttributes;
                for (int i = 0; i < attr.Count; i++)
                {
                    if (attr[i].AttributeType.Name == "AutoGeneratedAttribute")
                    {
                        attr.RemoveAt(i);
                        i--;
                    }
                }
            }
        }
        static void ProcessMethod(MethodDefinition wrapper, MethodDefinition native, int slot,
                                  FieldDefinition entry_points, IEnumerable<string> options)
        {
            var body = wrapper.Body;
            var il = body.GetILProcessor();
            var instructions = body.Instructions;
            instructions.Clear();
            DebugVariables vars = null;
            if (options.Contains("-debug"))
            {
                vars = EmitDebugPrologue(wrapper, il);
            }
            if (wrapper.Parameters.Count == native.Parameters.Count)
            {
                EmitParameters(wrapper, body, il);
            }
            else
            {
                int difference = native.Parameters.Count - wrapper.Parameters.Count;
                EmitConvenienceWrapper(wrapper, native, difference, body, il);
            }
            if (slot != -1)
            {
                EmitEntryPoint(entry_points, il, slot);
                EmitCalli(il, native);
            }
            else
            {
                EmitCall(il, native);
            }
            if (wrapper.ReturnType.Name != "Void")
            {
                EmitReturnTypeWrapper(wrapper, native, body, il);
            }
            EmitParameterEpilogues(wrapper, native, body, il);
            if (options.Contains("-debug"))
            {
                EmitDebugEpilogue(wrapper, il, vars);
            }
            il.Emit(OpCodes.Ret);
            if (body.Variables.Count > 0)
            {
                body.InitLocals = true;
            }
            body.OptimizeMacros();
        }
        class DebugVariables
        {
            public TypeDefinition ErrorHelperType;
            public VariableDefinition ErrorHelperLocal;
            public MethodReference Get_CurrentContext;
            public MethodReference Set_ErrorChecking;
            public Instruction BeginTry;
        }
        static DebugVariables EmitDebugPrologue(MethodDefinition wrapper, ILProcessor il)
        {
            DebugVariables vars = null;
            if (il.Body.Method.Name != "GetError")
            {
                var module = il.Body.Method.FullName;
                module = module.Substring(module.IndexOf(' ') + 1);
                module = module.Substring(0, module.IndexOf("::"));
                module = module.Substring(0, module.LastIndexOf('.'));
                if (module == "OpenTK.Graphics.OpenGL4" ||
                    module == "OpenTK.Graphics.OpenGL" ||
                    module == "OpenTK.Graphics.ES10" ||
                    module == "OpenTK.Graphics.ES11" ||
                    module == "OpenTK.Graphics.ES20" ||
                    module == "OpenTK.Graphics.ES30")
                {
                    var errorHelperType = wrapper.Module.GetType(module, "ErrorHelper");
                    if (errorHelperType != null)
                    {
                        vars = new DebugVariables();
                        vars.ErrorHelperType = errorHelperType;
                        var graphicsContext = wrapper.Module.Types.First(
                            type => type.FullName == "OpenTK.Graphics.GraphicsContext");
                        var iGraphicsContext = wrapper.Module.Types.First(
                            type => type.FullName == "OpenTK.Graphics.IGraphicsContext");
                        var ctor = vars.ErrorHelperType.GetConstructors().FirstOrDefault(
                            c => c.Parameters.Count == 1 &&
                            c.Parameters[0].ParameterType.FullName == iGraphicsContext.FullName);
                        if (ctor == null)
                        {
                            throw new InvalidOperationException(
                                String.Format(
                                    "{0} does needs a constructor taking {1}",
                                    errorHelperType,
                                    graphicsContext));
                        }
                        vars.Get_CurrentContext = graphicsContext.Methods.First(
                            method => method.Name == "get_CurrentContext");
                        vars.Set_ErrorChecking = graphicsContext.Methods.First(
                            method => method.Name == "set_ErrorChecking");
                        vars.ErrorHelperLocal = new VariableDefinition(vars.ErrorHelperType);
                        il.Body.Variables.Add(vars.ErrorHelperLocal);
                        il.Emit(OpCodes.Ldloca, vars.ErrorHelperLocal);
                        il.Emit(OpCodes.Call, vars.Get_CurrentContext);
                        il.Emit(OpCodes.Call, ctor);
                        vars.BeginTry = Instruction.Create(OpCodes.Nop);
                        il.Append(vars.BeginTry);
                        if (il.Body.Method.Name == "Begin")
                        {
                            il.Emit(OpCodes.Call, vars.Get_CurrentContext);
                            il.Emit(OpCodes.Ldc_I4_0);
                            il.Emit(OpCodes.Conv_I1);
                            il.Emit(OpCodes.Call, vars.Set_ErrorChecking);
                        }
                    }
                }
            }
            return vars;
        }
        static void EmitDebugEpilogue(MethodDefinition wrapper, ILProcessor il, DebugVariables vars)
        {
            if (vars != null)
            {
                var disposeMethod = vars.ErrorHelperType.Methods.First(
                    method => method.Name == "Dispose");
                var resultLocal = new VariableDefinition(wrapper.ReturnType);
                if (resultLocal.VariableType.FullName != Program.TypeVoid.FullName)
                {
                    il.Body.Variables.Add(resultLocal);
                    il.Emit(OpCodes.Stloc, resultLocal);
                }
                if (il.Body.Method.Name == "End")
                {
                    il.Emit(OpCodes.Call, vars.Get_CurrentContext);
                    il.Emit(OpCodes.Ldc_I4_1);
                    il.Emit(OpCodes.Conv_I1);
                    il.Emit(OpCodes.Call, vars.Set_ErrorChecking);
                }
                var nopInstruction = Instruction.Create(OpCodes.Nop);
                var loadInstruction = Instruction.Create(OpCodes.Ldloca, vars.ErrorHelperLocal);
                var disposeInstruction = Instruction.Create(OpCodes.Call, disposeMethod);
                var endFinallyInstruction = Instruction.Create(OpCodes.Endfinally);
                var endTryInstruction = Instruction.Create(OpCodes.Leave, nopInstruction);
                il.Append(endTryInstruction);
                il.Append(loadInstruction);
                il.Append(disposeInstruction);
                il.Append(endFinallyInstruction);
                il.Append(nopInstruction);
                var finallyHandler = new ExceptionHandler(ExceptionHandlerType.Finally);
                finallyHandler.TryStart = vars.BeginTry;
                finallyHandler.TryEnd = loadInstruction;
                finallyHandler.HandlerStart = loadInstruction;
                finallyHandler.HandlerEnd = nopInstruction;
                il.Body.ExceptionHandlers.Add(finallyHandler);
                if (resultLocal.VariableType.FullName != Program.TypeVoid.FullName)
                {
                    il.Emit(OpCodes.Ldloc, resultLocal);
                }
            }
        }
        private static void EmitReturnTypeWrapper(MethodDefinition wrapper, MethodDefinition native, MethodBody body, ILProcessor il)
        {
            if (wrapper.Parameters.Count < native.Parameters.Count)
            {
                il.Emit(OpCodes.Ldloc, body.Variables.Count - 1);
            }
            else if (wrapper.ReturnType != native.ReturnType)
            {
                if (wrapper.ReturnType.Name == "String")
                {
                    var intptr_to_voidpointer = wrapper.Module.Import(mscorlib.MainModule.GetType("System.IntPtr").GetMethods()
                        .First(m =>
                    {
                        return
                                m.Name == "op_Explicit" &&
                        m.ReturnType.Name == "Void*";
                    }));
                    var string_constructor = wrapper.Module.Import(mscorlib.MainModule.GetType("System.String").GetConstructors()
                        .First(m =>
                    {
                        var p = m.Parameters;
                        return p.Count > 0 && p[0].ParameterType.Name == "SByte*";
                    }));
                    il.Emit(OpCodes.Call, intptr_to_voidpointer);
                    il.Emit(OpCodes.Newobj, string_constructor);
                }
                else if (wrapper.ReturnType.Resolve().IsEnum)
                {
                }
                else if (wrapper.ReturnType.Name == "Boolean" && native.ReturnType.Name == "Byte")
                {
                }
                else
                {
                    Console.Error.WriteLine("Return wrapper for '{1}' not implemented yet ({0})", native.Name, wrapper.ReturnType.Name);
                }
            }
            else
            {
            }
        }
        static void EmitParameterEpilogues(MethodDefinition wrapper, MethodDefinition native, MethodBody body, ILProcessor il)
        {
            foreach (var p in wrapper.Parameters)
            {
                if (p.ParameterType.Name == "StringBuilder")
                {
                    EmitStringBuilderEpilogue(wrapper, native, p, body, il);
                }
                if (!p.ParameterType.IsArray && p.ParameterType.Name == "String")
                {
                    EmitStringEpilogue(wrapper, p, body, il);
                }
                if (p.ParameterType.IsArray && p.ParameterType.GetElementType().Name == "String")
                {
                    EmitStringArrayEpilogue(wrapper, p, body, il);
                }
            }
        }
        static void EmitStringBuilderParameter(MethodDefinition method, ParameterDefinition parameter, MethodBody body, ILProcessor il)
        {
            var p = parameter.ParameterType;
            var sb_get_capacity = method.Module.Import(TypeStringBuilder.Methods.First(m => m.Name == "get_Capacity"));
            var alloc_hglobal = method.Module.Import(TypeMarshal.Methods.First(m => m.Name == "AllocHGlobal"));
            var variable_name = parameter.Name + " _sb_ptr";
            body.Variables.Add(new VariableDefinition(variable_name, TypeIntPtr));
            int index = body.Variables.Count - 1;
            il.Emit(OpCodes.Callvirt, sb_get_capacity);
            il.Emit(OpCodes.Call, alloc_hglobal);
            il.Emit(OpCodes.Stloc, index);
            il.Emit(OpCodes.Ldloc, index);
        }
        static void EmitStringBuilderEpilogue(MethodDefinition wrapper, MethodDefinition native, ParameterDefinition parameter, MethodBody body, ILProcessor il)
        {
            var p = parameter.ParameterType;
            if (p.Name == "StringBuilder")
            {
                var ptr_to_sb = wrapper.Module.Import(TypeBindingsBase.Methods.First(m => m.Name == "MarshalPtrToStringBuilder"));
                var free_hglobal = wrapper.Module.Import(TypeMarshal.Methods.First(m => m.Name == "FreeHGlobal"));
                var block = new ExceptionHandler(ExceptionHandlerType.Finally);
                block.TryStart = body.Instructions[0];
                var variable_name = parameter.Name + " _sb_ptr";
                var v = body.Variables.First(m => m.Name == variable_name);
                il.Emit(OpCodes.Ldloc, v.Index);
                il.Emit(OpCodes.Ldarg, parameter.Index);
                il.Emit(OpCodes.Call, ptr_to_sb);
                block.TryEnd = body.Instructions.Last();
                block.HandlerStart = body.Instructions.Last();
                il.Emit(OpCodes.Ldloc, v.Index);
                il.Emit(OpCodes.Call, free_hglobal);
                block.HandlerEnd = body.Instructions.Last();
            }
        }
        static void EmitStringParameter(MethodDefinition wrapper, ParameterDefinition parameter, MethodBody body, ILProcessor il)
        {
            var p = parameter.ParameterType;
            var marshal_str_to_ptr = wrapper.Module.Import(TypeBindingsBase.Methods.First(m => m.Name == "MarshalStringToPtr"));
            var variable_name = parameter.Name + "_string_ptr";
            body.Variables.Add(new VariableDefinition(variable_name, TypeIntPtr));
            int index = body.Variables.Count - 1;
            il.Emit(OpCodes.Call, marshal_str_to_ptr);
            il.Emit(OpCodes.Stloc, index);
            il.Emit(OpCodes.Ldloc, index);
        }
        static void EmitStringEpilogue(MethodDefinition wrapper, ParameterDefinition parameter, MethodBody body, ILProcessor il)
        {
            var p = parameter.ParameterType;
            var free = wrapper.Module.Import(TypeBindingsBase.Methods.First(m => m.Name == "FreeStringPtr"));
            var variable_name = parameter.Name + "_string_ptr";
            var v = body.Variables.First(m => m.Name == variable_name);
            il.Emit(OpCodes.Ldloc, v.Index);
            il.Emit(OpCodes.Call, free);
        }
        static void EmitStringArrayParameter(MethodDefinition wrapper, ParameterDefinition parameter, MethodBody body, ILProcessor il)
        {
            var p = parameter.ParameterType;
            var marshal_str_array_to_ptr = wrapper.Module.Import(TypeBindingsBase.Methods.First(m => m.Name == "MarshalStringArrayToPtr"));
            var variable_name = parameter.Name + "_string_array_ptr";
            body.Variables.Add(new VariableDefinition(variable_name, TypeIntPtr));
            int index = body.Variables.Count - 1;
            il.Emit(OpCodes.Call, marshal_str_array_to_ptr);
            il.Emit(OpCodes.Stloc, index);
            il.Emit(OpCodes.Ldloc, index);
        }
        static void EmitStringArrayEpilogue(MethodDefinition wrapper, ParameterDefinition parameter, MethodBody body, ILProcessor il)
        {
            var p = parameter.ParameterType;
            var free = wrapper.Module.Import(TypeBindingsBase.Methods.First(m => m.Name == "FreeStringArrayPtr"));
            var variable_name = parameter.Name + "_string_array_ptr";
            var v = body.Variables.First(m => m.Name == variable_name);
            il.Emit(OpCodes.Ldloc, v.Index);
            il.Emit(OpCodes.Ldarg, parameter.Index);
            il.Emit(OpCodes.Ldlen);
            il.Emit(OpCodes.Conv_I4);
            il.Emit(OpCodes.Call, free);
        }
        static void EmitConvenienceWrapper(MethodDefinition wrapper,
            MethodDefinition native, int difference, MethodBody body, ILProcessor il)
        {
            if (wrapper.Parameters.Count > 2)
            {
                throw new NotImplementedException();
            }
            if (wrapper.ReturnType.Name != "Void")
            {
                if (difference == 2)
                {
                    body.Variables.Add(new VariableDefinition(wrapper.ReturnType));
                    il.Emit(OpCodes.Ldc_I4, 1); 
                    il.Emit(OpCodes.Ldloca, body.Variables.Count - 1); 
                }
                else if (difference == 1)
                {
                    body.Variables.Add(new VariableDefinition(wrapper.ReturnType));
                    EmitParameters(wrapper, body, il);
                    il.Emit(OpCodes.Ldloca, body.Variables.Count - 1);
                }
                else
                {
                    Console.Error.WriteLine("Unknown wrapper type for ({0})", native.Name);
                }
            }
            else
            {
                if (difference == 1)
                {
                    il.Emit(OpCodes.Ldc_I4, 1); 
                    il.Emit(OpCodes.Ldarga, wrapper.Parameters.Last()); 
                }
                else
                {
                    Console.Error.WriteLine("Unknown wrapper type for ({0})", native.Name);
                }
            }
        }
        static int EmitParameters(MethodDefinition method, MethodBody body, ILProcessor il)
        {
            int i;
            for (i = 0; i < method.Parameters.Count; i++)
            {
                var parameter = method.Parameters[i];
                var p = method.Module.Import(method.Parameters[i].ParameterType);
                il.Emit(OpCodes.Ldarg, i);
                if (p.Name == "StringBuilder")
                {
                    EmitStringBuilderParameter(method, parameter, body, il);
                }
                else if (p.Name == "String" && !p.IsArray)
                {
                    EmitStringParameter(method, parameter, body, il);
                }
                else if (p.IsByReference)
                {
                    body.Variables.Add(new VariableDefinition(new PinnedType(p)));
                    var index = body.Variables.Count - 1;
                    il.Emit(OpCodes.Stloc, index);
                    il.Emit(OpCodes.Ldloc, index);
                    il.Emit(OpCodes.Conv_I);
                }
                else if (p.IsArray)
                {
                    if (p.Name != method.Module.Import(typeof(string[])).Name)
                    {
                        var array = (ArrayType)p;
                        var element_type = p.GetElementType();
                        body.Variables.Add(new VariableDefinition(new PinnedType(new ByReferenceType(element_type))));
                        int pinned_index = body.Variables.Count - 1;
                        var empty = il.Create(OpCodes.Ldc_I4, 0);
                        var pin = il.Create(OpCodes.Ldarg, i);
                        var end = il.Create(OpCodes.Stloc, pinned_index);
                        il.Emit(OpCodes.Brfalse, empty);
                        il.Emit(OpCodes.Ldarg, i);
                        if (array.Rank == 1)
                        {
                            il.Emit(OpCodes.Ldlen);
                            il.Emit(OpCodes.Conv_I4);
                        }
                        else
                        {
                            var get_length = method.Module.Import(
                                mscorlib.MainModule.GetType("System.Array").Methods.First(m => m.Name == "get_Length"));
                            il.Emit(OpCodes.Callvirt, get_length);
                        }
                        il.Emit(OpCodes.Brtrue, pin);
                        il.Append(empty);
                        il.Emit(OpCodes.Conv_U);
                        il.Emit(OpCodes.Br, end);
                        il.Append(pin);
                        if (array.Rank == 1)
                        {
                            il.Emit(OpCodes.Ldc_I4, 0);
                            il.Emit(OpCodes.Ldelema, element_type);
                        }
                        else
                        {
                            ByReferenceType t_ref = array.ElementType.MakeByReferenceType();
                            MethodReference get_address = new MethodReference("Address", t_ref, array);
                            for (int r = 0; r < array.Rank; r++)
                            {
                                get_address.Parameters.Add(new ParameterDefinition(TypeInt32));
                            }
                            get_address.HasThis = true;
                            for (int r = 0; r < array.Rank; r++)
                            {
                                il.Emit(OpCodes.Ldc_I4, 0);
                            }
                            il.Emit(OpCodes.Call, get_address);
                        }
                        il.Append(end);
                        il.Emit(OpCodes.Ldloc, pinned_index);
                        il.Emit(OpCodes.Conv_I);
                    }
                    else
                    {
                        EmitStringArrayParameter(method, parameter, body, il);
                    }
                }
            }
            return i;
        }
        static void EmitEntryPoint(FieldDefinition entry_points, ILProcessor il, int slot)
        {
            il.Emit(OpCodes.Ldsfld, entry_points);
            il.Emit(OpCodes.Ldc_I4, slot);
            il.Emit(OpCodes.Ldelem_I);
        }
        static void EmitCalli(ILProcessor il, MethodReference reference)
        {
            var signature = new CallSite(reference.ReturnType)
            {
                CallingConvention = MethodCallingConvention.StdCall,
            };
            foreach (var p in reference.Parameters)
            {
                signature.Parameters.Add(p);
            }
            il.Emit(OpCodes.Calli, signature);
        }
        static void EmitCall(ILProcessor il, MethodReference reference)
        {
            il.Emit(OpCodes.Call, reference);
        }
    }
}

===== D:\posso\Projects\Projects\محمد فراس زعيتر مشاريع\OpenTK\1.1\Source\OpenTK\Compute\Program.cs =====
#region License
#endregion
using System;
using System.Runtime.InteropServices;
namespace OpenTK.Compute
{
}

===== D:\posso\Projects\Projects\محمد فراس زعيتر مشاريع\Robot\SharpGLWinformsApplication2\Program.cs =====
using System;
using System.Collections.Generic;
using System.Linq;
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
