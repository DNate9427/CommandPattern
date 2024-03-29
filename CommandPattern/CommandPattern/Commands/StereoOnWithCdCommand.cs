﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Objects;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Commands
{
    public class StereoOnWithCdCommand:ICommand
    {
        public Stereo Stereo { get; set; }
     
        public StereoOnWithCdCommand(Stereo stereo)
        {
            Stereo = stereo;
        }

        public void Execute()
        {
            Stereo.On();
            Stereo.SetCd();
            Stereo.SetVolume(11);
        }
    }
}
