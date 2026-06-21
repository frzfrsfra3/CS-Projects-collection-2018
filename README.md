# C# Projects Collection

A curated collection of 22 C# projects covering graphics programming, cryptography, file processing, and Windows Forms applications. These projects were originally developed for educational purposes and have been cleaned and restructured into a unified repository.

---

## Table of Contents

- [Project Overview](#project-overview)
- [Directory Structure](#directory-structure)
- [Project Details](#project-details)
- [Prerequisites](#prerequisites)
- [How to Build](#how-to-build)
- [Technologies Used](#technologies-used)
- [License](#license)

---

## Project Overview

| # | Project | Category | Description |
|---|---------|----------|-------------|
| 1 | `circlearound_orbit` | Graphics | WinForms application demonstrating orbital/circular motion |
| 2 | `circles` | Graphics | WinForms application for circle rendering |
| 3 | `ConsoleApplication1` | Cryptography | Caesar cipher encoder/decoder |
| 4 | `ConsoleApplication2` | Graphics | Placeholder/stub for line drawing algorithm |
| 5 | `ConsoleApplication3` | Graphics | OpenGL circle points using Tao/FreeGlut |
| 6 | `develop_outer_files` | File I/O | Simple text file reader |
| 7 | `distinctfile` | File I/O | Removes duplicate lines from text files |
| 8 | `Draw_1` | Graphics | WinForms drawing application |
| 9 | `hindu_1_open_gl` | Graphics | OpenTK GameWindow with UI integration |
| 10 | `megefiles` | File I/O | Merges 29 name dictionary files into one |
| 11 | `Mhd_feras_ze_transformation` | Graphics | WinForms geometric transformation demo |
| 12 | `nenene` | Utility | Generates all 6-digit number combinations (000000–999999) |
| 13 | `Robot_SharpGL` | Graphics | SharpGL-based WinForms robot visualization |
| 14 | `SharpGLWinformsApplication1` | Graphics | SharpGL WinForms template |
| 15 | `SharpGLWinformsApplication3` | Graphics | SharpGL WinForms template |
| 16 | `techdump` | Graphics | OpenTK-based application (60 FPS target) |
| 17 | `texture_box` | Graphics | OpenTK texture rendering demo |
| 18 | `win_fero` | WinForms | General-purpose WinForms application |
| 19 | `WindowsFormsApplication1` | WinForms | WinForms application |
| 20 | `WindowsFormsApplication2` | WinForms | WinForms application |
| 21 | `WindowsFormsApplication3` | WinForms | WinForms application |
| 22 | `WindowsFormsApplication4` | WinForms | WinForms application |

---

## Directory Structure

```
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
```

---

## Project Details

### ConsoleApplication1 — Caesar Cipher
A simple console-based Caesar cipher implementation.

**Features:**
- Encrypts lowercase input using a numeric shift key
- Decrypts the ciphertext back to plaintext
- Operates on the 26-letter English alphabet

**Example:**
```
Input:  hello
Key:    3
Output: KHOOR
```

**Note:** The implementation uses uppercase alphabet indexing for the cipher table while accepting lowercase input.

---

### ConsoleApplication2 — Line Drawing Placeholder
A stub project intended for a line-drawing algorithm (e.g., Bresenham's or DDA). The `linesimple` method is defined but not yet implemented.

```csharp
public void linesimple(int x0, int y0, int x1, int y1, ConsoleColor Color)
{
    // TODO: Implement line drawing logic
}
```

---

### ConsoleApplication3 — OpenGL Circle Points
Renders a circle using individual points via the Tao.OpenGl / FreeGlut bindings.

**Key APIs:**
- `Glut.glutInit()` — Initialize GLUT
- `Gl.glBegin(Gl.GL_POINTS)` — Point-based circle tessellation
- `Glu.gluPerspective()` — Perspective projection setup

**Note:** This project requires the Tao Framework and FreeGlut DLLs to run.

---

### develop_outer_files — File Reader
Reads and prints the contents of `data.txt` line by line.

```csharp
using (StreamReader fileReader = new StreamReader("data.txt"))
{
    while (!fileReader.EndOfStream)
    {
        string line = fileReader.ReadLine();
        Console.WriteLine(line);
    }
}
```

---

### distinctfile — Duplicate Line Remover
Removes duplicate lines from a text file using a `HashSet<string>`.

**Input:** `arabsfull.txt`  
**Output:** `arabsfull_Distinct.txt`

```csharp
HashSet<string> previousLines = new HashSet<string>();
while ((currentLine = reader.ReadLine()) != null)
{
    if (previousLines.Add(currentLine))
        writer.WriteLine(currentLine);
}
```

---

### megefiles — Multi-File Merger
Interleaves 29 dictionary/name files into a single output file. Files are processed line-by-line in parallel (round-robin style).

**Source files include:**
- Arabic names (male/female)
- Chinese names
- French, German, Norwegian, Swedish, Finnish names
- Shakespeare names
- Movie characters
- US Congress names
- And more...

**Output:** `MaximumXXXOptions.txt`

---

### nenene — Number Generator
Generates every possible 6-digit combination from `000000` to `999999` and writes them to `e:\Tank\6num`.

**Note:** This produces 1,000,000 lines. Ensure sufficient disk space.

---

### Graphics & OpenGL Projects

#### SharpGL Projects
- `Robot_SharpGL`
- `SharpGLWinformsApplication1`
- `SharpGLWinformsApplication3`

These use the [SharpGL](https://github.com/dwmkerr/sharpgl) library to host an OpenGL context inside a Windows Forms window.

#### OpenTK Projects
- `hindu_1_open_gl` — OpenTK `GameWindow` with an external UI form
- `texture_box` — OpenTK `GameWindow` for texture rendering
- `techdump` — OpenTK application running at 60 FPS

#### WinForms Graphics
- `circlearound_orbit` — Orbital animation
- `circles` — Circle rendering
- `Draw_1` — Freehand drawing application
- `Mhd_feras_ze_transformation` — Geometric transformations
- `win_fero` — General WinForms app
- `WindowsFormsApplication1–4` — Various WinForms projects

---

## Prerequisites

| Technology | Required By |
|------------|-------------|
| .NET Framework 4.x / .NET 6+ | All projects |
| Tao Framework | `ConsoleApplication3` |
| FreeGlut DLLs | `ConsoleApplication3` |
| OpenTK (NuGet) | `hindu_1_open_gl`, `texture_box`, `techdump` |
| SharpGL (NuGet) | `Robot_SharpGL`, `SharpGLWinformsApplication1/3` |

### Installing Dependencies

For OpenTK projects:
```bash
dotnet add package OpenTK
```

For SharpGL projects:
```bash
dotnet add package SharpGL
```

---

## How to Build

### Option 1: Visual Studio
1. Open the desired `.csproj` or create a new project.
2. Copy the `Program.cs` content into the project.
3. Restore NuGet packages if needed.
4. Build and run (F5).

### Option 2: .NET CLI
```bash
cd <ProjectFolder>
dotnet new console --force   # or dotnet new winforms
dotnet restore
dotnet build
dotnet run
```

---

## Technologies Used

- **C#** — Primary language
- **Windows Forms** — Desktop UI framework
- **OpenGL** — Cross-platform graphics API (via Tao, SharpGL, and OpenTK)
- **OpenTK** — OpenGL/OpenAL bindings for .NET
- **SharpGL** — OpenGL wrapper for WinForms/WPF
- **Tao Framework** — Legacy OpenGL/FreeGlut bindings

---

## Notes

- All `Program.cs` files retain their original namespaces and logic.
- Student-specific folders and personal identifiers have been removed.
- Some projects contain hardcoded absolute paths (e.g., `E:\tank\...`). Update these before running on your machine.
- Several WinForms projects reference `Form1`, `SharpGLForm`, or `MainWindow` classes that are not included in the `Program.cs` files alone. You will need to add the corresponding designer/form files or recreate the UI.

---

## License

This collection is provided for educational and reference purposes. Original authorship is preserved per project namespace. No explicit license is attached; please respect academic integrity if reusing any code.

---

*Generated from the cleaned and restructured C# Projects Collection.*
