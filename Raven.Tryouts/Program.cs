﻿using System;
using Raven.Abstractions.Data;
using Raven.Database.Config;
using Raven.Database.Plugins;
using Raven.Database.Server;
using Raven.Database.Extensions;

namespace Raven.Tryouts
{
	internal class Program
	{
		private static void Main()
		{
			CertGenerator.GenerateNewCertificate("raven.cert");
		}
	}
}