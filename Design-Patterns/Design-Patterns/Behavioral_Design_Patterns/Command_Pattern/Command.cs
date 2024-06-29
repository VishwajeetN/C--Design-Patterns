using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Design_Patterns.Command_Pattern
{
    internal class Command
    {
        // Command interface.
        public interface ICommand
        {
            void Execute();
        }

        // Receiver to receive the command.
        public interface IFileSystemReceiver
        {
            // Declare the Actions.
            void openFile();
            void writeFile();
            void closeFile();
        }

        // Receiver concrete class.
        public class LinuxFileSystemReceiver : IFileSystemReceiver
        {
            public void openFile()
            {
                Console.WriteLine("Opening file in Linux OS.");
            }

            public void writeFile()
            {
                Console.WriteLine("Writing file in Linux OS.");
            }

            public void closeFile()
            {
                Console.WriteLine("Closing file in Linux OS.");
            }
        }

        // Receiver concrete class.
        public class WindowsFileSystemReceiver : IFileSystemReceiver
        {
            public void openFile()
            {
                Console.WriteLine("Opening file in Windows OS.");
            }

            public void writeFile()
            {
                Console.WriteLine("Writing file in Windows OS.");
            }

            public void closeFile()
            {
                Console.WriteLine("Closing file in Windows OS.");
            }
        }

        // Open File Command
        public class OpenFileCommand : ICommand
        {
            private IFileSystemReceiver _fileSystem;

            public OpenFileCommand(IFileSystemReceiver fileSystem)
            {
                _fileSystem = fileSystem;
            }

            public void Execute() {

                _fileSystem.openFile();
            }
        }


        // Write File Command
        public class WriteFileCommand : ICommand
        {
            private IFileSystemReceiver _fileSystem;

            public WriteFileCommand(IFileSystemReceiver fileSystem)
            {
                _fileSystem = fileSystem;
            }

            public void Execute()
            {

                _fileSystem.writeFile();
            }
        }

        // Close File Command
        public class CloseFileCommand : ICommand
        {
            private IFileSystemReceiver _fileSystem;

            public CloseFileCommand(IFileSystemReceiver fileSystem)
            {
                _fileSystem = fileSystem;
            }

            public void Execute()
            {
                _fileSystem.closeFile();
            }
        }

        // File Invoker through which the invoking will be done.

        public class FileInvoker
        {
            ICommand _command;

            public FileInvoker(ICommand command)
            {
                this._command = command;
            }

            public void InovkeExecute()
            {
                this._command.Execute();
            }

        }


    }
}
