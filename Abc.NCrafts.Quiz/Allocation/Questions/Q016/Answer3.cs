﻿namespace Abc.NCrafts.Quiz.Allocation.Questions.Q016
{
    public class Answer3
    {
        public static void Run()
        {
            // begin
            var code = new NCrafts().GetHashCode();
            // end
            
            Logger.Log(code);
        }

        public struct NCrafts
        {
        }
    }
}
