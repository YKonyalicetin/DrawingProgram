//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace DrawingProgram
{
    class StickFigureDimensions
    {
        private readonly int Yvalue;

        //Class Constructor gets called when a new object from class is constructed
        public StickFigureDimensions(int mouseY, int mouseY1)
        {
            BaseUnit = (mouseY1 - mouseY) / 10; //getting height of the object
                                                //division by 10 simulates a 10x10 grid in order to determine object size 
            Yvalue = mouseY;
        }

        public int BaseUnit { get; } //auto property: just height divided by width

        /// <summary>
        /// Get the diameter of the head for a stick figure
        /// </summary>
        public int HeadDiameter //3 units for head
        {
            get { return BaseUnit * 3; }
        }

        /// <summary>
        /// Get the radius of the head for a stick figure
        /// </summary>
        public int HeadRadius
        {
            get { return (BaseUnit * 3) / 2; }
        }

        /// <summary>
        /// Get the size of the body for a stick figure
        /// </summary>
        public int BodySize
        {
            get { return BaseUnit * 4; }
        }


        public int MidBody //middle point of the body
        {
            get { return Yvalue + (BaseUnit * 5); }
        }

        /// <summary>
        /// Get the size of the leg for a stick figure
        /// </summary>
        public int LegSize
        {
            get { return BaseUnit * 3; }
        }
    }
}
