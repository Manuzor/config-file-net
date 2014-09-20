﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.FileIO
{
    public class ConfigFileWriter : ConfigFileReaderWriterBase
    {
        public bool OverwriteExisting { get; set; }

        public ConfigFileWriter() : base()
        {
            OverwriteExisting = false;
        }

        public void Write(ConfigFile cfg)
        {
            if (OverwriteExisting)
            {
                Overwrite(cfg);
                return;
            }
            throw new NotImplementedException();
        }

        private void Overwrite(ConfigFile cfg)
        {
            throw new NotImplementedException();
        }
    }
}
