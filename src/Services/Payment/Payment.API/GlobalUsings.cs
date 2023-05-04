﻿global using Autofac.Extensions.DependencyInjection;
global using Autofac;
global using Azure.Core;
global using Azure.Identity;
global using HealthChecks.UI.Client;
global using Microsoft.AspNetCore.Diagnostics.HealthChecks;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore;
global using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Abstractions;
global using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Events;
global using Microsoft.eShopOnContainers.BuildingBlocks.EventBus;
global using Microsoft.eShopOnContainers.BuildingBlocks.EventBusRabbitMQ;
global using Microsoft.eShopOnContainers.BuildingBlocks.EventBusServiceBus;
global using Microsoft.eShopOnContainers.Payment.API.IntegrationEvents.Events;
global using Microsoft.Extensions.Diagnostics.HealthChecks;
global using Microsoft.Extensions.Options;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using Microsoft.eShopOnContainers.Payment.API.IntegrationEvents.EventHandling;
global using Microsoft.eShopOnContainers.Payment.API;
global using RabbitMQ.Client;
global using System.Threading.Tasks;
global using System;
global using System.IO;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.Extensions.Hosting;
