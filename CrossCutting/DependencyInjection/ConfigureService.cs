﻿using Application.Services;
using Domain.Interfaces.Services.Aluno;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.DependencyInjection {
    public class ConfigureService {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection) {
            serviceCollection.AddScoped<IAlunoService, AlunoService>();
        }
    }
}
