using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGrader
{
    class GradeInformation
    {
        // Constuctor(s) //
        public GradeInformation()
        {
            this.executionLog = new LinkedList<string>();
            this.filePath     = String.Empty;
            this.grade        = 0.0;
            this.name         = String.Empty;
        }

        // Public Properties //

        // Gets the execution log
        public LinkedList<string> ExecutionLog
        {
            get { return this.executionLog; }
        }

        // Get/sets the filepath
        public string FilePath
        {
            get => this.filePath;
            set => this.filePath = value;
        }

        // Gets/sets the grade
        public double Grade
        {
            get => (double)this.grade;
            set => this.grade = value;
        }
        
        // Gets/sets the name
        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        // Override(s) //

        public override string ToString()
        {
            return "| Name: "      + name +
                   "| File Path: " + filePath +
                   "| Grade: "     + grade + 
                   "| Log: "       + executionLog.ToString();
        }

        // Public Methods //

        public void addLog(string logEntry)
        {
            executionLog.Append(logEntry);
        }

        // Private Methods //


        // Private Variables //

        private LinkedList<string> executionLog; // The execution log of the program.
        private string             filePath;     // The filepath of the program.
        private double             grade;        // The grade of the program.
        private string             name;         // The name of the top-level directory (student name).
    }
}
