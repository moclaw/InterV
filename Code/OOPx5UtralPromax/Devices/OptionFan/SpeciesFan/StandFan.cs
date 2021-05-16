﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOPx5UtralPromax.Devices.OptionFan.SpeciesFan
{
    class StandFan : FanClass
    {
        public StandFan()
        {
            price = 500;
        }

        public override string OutputDetailBill()
        {
            return $"Máy quạt: {idDevices} " +
                $"Loại máy quạt (quạt đứng) {nameDevices} {company} " +
                $"{this.price * amountSale} {amountSale}\n";
        }
    }
}
