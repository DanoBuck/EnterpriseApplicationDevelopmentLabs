using System;

namespace PracticeAssessment1.Classes
{
    public abstract class MediaFile
    {
        private string fileName;
        public string FileName {
            get
            {
                return fileName;
            }
            set
            {
                if(value == null || value == "")
                {
                    throw new ArgumentException("Cannot be null or empty");
                }
                else
                {
                    fileName = value;
                }
            }
        }

        protected MediaFile(string fileNameIn)
        {
            fileName = fileNameIn;
        }

        public override string ToString()
        {
            return "File Name: " + FileName;
        }
    }
}
