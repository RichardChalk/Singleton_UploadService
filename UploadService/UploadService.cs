﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UploadService
{
    public class UploadService
    {
        private UploadService() {}
        private static UploadService _instance;
        private int _counter;

        public static UploadService GetInstance()
        {
            if (_instance == null)
                _instance = new UploadService();
            return _instance;
        }
        public int TimesCalled()
        {
            return ++_counter;
        }
    }
}
