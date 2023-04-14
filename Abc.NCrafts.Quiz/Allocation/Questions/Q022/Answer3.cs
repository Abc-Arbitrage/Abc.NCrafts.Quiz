﻿using System.Collections.Generic;

namespace Abc.NCrafts.Quiz.Allocation.Questions.Q022
{
    public class Answer3
    {
        public static void Run()
        {
            // begin
            var data = new Data();
            data.Ids[0] = 999;
            // end

            Logger.Log("Value: ", data.Ids[0]);
        }

        private struct Data
        {
            public List<int> Ids;

            public Data()
            {
                Ids = new();
            }
        }
    }
}
