﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5HW1.Interfaces
{
    public interface IHttpService
    {
        public Task SendAsync(HttpRequestMessage? httpMessage);
    }
}
