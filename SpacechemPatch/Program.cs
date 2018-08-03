using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace SpacechemPatch
{
    class Program
    {

        static void Main(string[] args)
        {
            string gameFolder = "";
            if (args.Length >= 1)
            {
                gameFolder = args[0];
            }
            string originalExecutablePath = Path.Combine(gameFolder, "SpaceChem.exe");
            string backupPath = Path.Combine(gameFolder, "SpaceChem.exe.original");
            string patchedPath = Path.Combine(gameFolder, "SpaceChem.exe.patched");
            if (!File.Exists(originalExecutablePath))
            {
                Console.WriteLine("Can't find game executable " + originalExecutablePath + " ! " +
                    "Please execute this program from the SpaceChem game folder, or give the path of the game folder as a command line argument. Exiting...");
                return;
            }
            Console.WriteLine("This program is experimental and was only tested with the Steam version of the game. There is NO WARRANTY on it. Please remember that you can always restore the original game files by verifying game integrity in Steam.");
            Console.WriteLine("Do you want to continue? [y/N]");
            if (Console.ReadKey().Key != ConsoleKey.Y) return;
            Console.WriteLine();
            if (!File.Exists(backupPath))
            {
                Console.WriteLine("Making backup of SpaceChem.exe");
                File.Copy(originalExecutablePath, backupPath);
            }
            // TODO: Add a way to specify this by the end user.
            Patch[] enabledPatches = (Patch[])Enum.GetValues(typeof(Patch));
            Console.WriteLine("Patching...");
            using (ModuleDefinition spacechemAssembly = ModuleDefinition.ReadModule(originalExecutablePath))
            using (ModuleDefinition ownAssembly = ModuleDefinition.ReadModule(System.Reflection.Assembly.GetExecutingAssembly().Location))
            {
                Patcher patcher = new Patcher(ownAssembly, spacechemAssembly);
                patcher.ApplyPatches(enabledPatches);
                spacechemAssembly.Write(patchedPath);
            }
            File.Delete(originalExecutablePath);
            File.Move(patchedPath, originalExecutablePath);
            Console.WriteLine("All OK");
        }
    }
}
