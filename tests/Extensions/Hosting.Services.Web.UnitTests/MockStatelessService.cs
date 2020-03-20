﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using Microsoft.ServiceFabric.Services.Runtime;
using ServiceFabric.Mocks;

namespace Hosting.Services.Web.UnitTests
{
	internal class MockStatelessService : StatelessService
	{
		public MockStatelessService() : base(MockStatelessServiceContextFactory.Default) { }
	}
}
