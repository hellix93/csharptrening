﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("zzz");
            newData.Header = "ttt";
            newData.Footer = "qqq";
            int i = 0; //номер элемента который будем изменять

            app.Groups.CreateGroupIfNotExist(i); // вызов метода проверки существует ли группа, если группы нет создастся новая

            app.Groups.Modify(i, newData);
        }
    }
}
