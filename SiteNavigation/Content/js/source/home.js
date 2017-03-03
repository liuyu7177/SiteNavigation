$(function () {
    $('[data-toggle="popover"]').popover({
        html: true,
        title: "网易考拉海购微信交流群",
        placement: 'bottom',
        content: function () {
            return '<div class="hover-hovercard"><p>QQ群：189781646</p><p>微信群扫下面二维码：</p><img src="/Content/img/homeIndex/interflow.png" alt="考拉海购微信交流群"></div>';
        }
    }).on("mouseenter", function () {
        var _this = this;
        $(this).popover("show");
        $(this).siblings(".popover").on("mouseleave", function () {
            $(_this).popover('hide');
        });
    }).on("mouseleave", function () {
        var _this = this;
        setTimeout(function () {
            if (!$(".popover:hover").length) {
                $(_this).popover("hide")
            }
        }, 100);
    });
    $('[data-toggle="GoWebsite"]').popover({
        html: true,
        title: "去网易考拉海购官网",
        placement: 'bottom',
        content: function () {
            return '<div class="hover-hovercard"><a href="http://www.kaola.com" target="_blank">www.kaola.com</a></div>';
        }
    }).on("mouseenter", function () {
        var _this = this;
        $(this).popover("show");
        $(this).siblings(".popover").on("mouseleave", function () {
            $(_this).popover('hide');
        });
    }).on("mouseleave", function () {
        var _this = this;
        setTimeout(function () {
            if (!$(".popover:hover").length) {
                $(_this).popover("hide")
            }
        }, 100);
    });

    $('.carousel').carousel({
        interval: 5000
    })
    $('[data-toggle="MicroMall"]').popover({
        html: true,
        title: "微信扫一扫--网易考拉海购微商城",
        placement: 'top',
        content: function () {
            return '<div class="hover-hovercard"><img style="width:240px;" src="/Content/img/homeIndex/MicroMall.png" alt="考拉海购微信交流群"></div>';
        }
    }).on("mouseenter", function () {
        var _this = this;
        $(this).popover("show");
        $(this).siblings(".popover").on("mouseleave", function () {
            $(_this).popover('hide');
        });
    }).on("mouseleave", function () {
        var _this = this;
        setTimeout(function () {
            if (!$(".popover:hover").length) {
                $(_this).popover("hide")
            }
        }, 100);
    });
    $('[data-toggle="Customer"]').popover({
        html: true,
        title: "微信--考拉店主劲豪团队咨询客服",
        placement: 'top',
        content: function () {
            return '<div class="hover-hovercard"><img style="width:240px;" src="/Content/img/homeIndex/wodefan.jpg" alt="考拉店主劲豪团队咨询客服"></div>';
        }
    }).on("mouseenter", function () {
        var _this = this;
        $(this).popover("show");
        $(this).siblings(".popover").on("mouseleave", function () {
            $(_this).popover('hide');
        });
    }).on("mouseleave", function () {
        var _this = this;
        setTimeout(function () {
            if (!$(".popover:hover").length) {
                $(_this).popover("hide")
            }
        }, 100);
    });
});