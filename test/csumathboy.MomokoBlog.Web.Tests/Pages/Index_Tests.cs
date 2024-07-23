﻿using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace csumathboy.MomokoBlog.Pages;

public class Index_Tests : MomokoBlogWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
