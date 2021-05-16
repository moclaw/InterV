﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOPx5UtralPromax.Devices.OptionFan.SpeciesFan
{
    class BatteryFan : FanClass
    {
        private int batteryCapacity { get; set; }
        public BatteryFan()
        {   
            Console.Write("Dung tich nuoc: ");
            do
            {
                try
                {
                    batteryCapacity = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Write("Nhap lai: ");
                }

                if (batteryCapacity <= 0)
                {
                    Console.Write("Nhap lai: ");
                }
            } while (batteryCapacity <= 0);
            price = batteryCapacity * 500;
            Console.Write("Số lượng bán ra: ");

            amountSale = (int)double.Parse(Console.ReadLine());
        }
        public override string OutputDetailBill()
        {
            return $"\tMáy quạt: {idDevices} " +
                $"Loại máy quạt (quạt đứng) {nameDevices} {company} " +
                $"{price * amountSale} {amountSale}\n";

        }
    }
}
