using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


namespace ConferenceBarrel.Models 
{
    public class Conference 
    {
        public int Id { get; set;}
        public string Name {get; set;}
        public decimal TicketeVlaue {get; set;}

        public List<Session> Sessions {get; set;}


    }

}