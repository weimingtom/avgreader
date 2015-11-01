# Introduction #

ScriptReader是AVGreader运行脚本之前，最为重要的一个调试工具。


# Details #

游戏脚本是否能顺利用ScriptReader跑起来，也直接决定了它能不能最终在AVGreader上跑起来。
并且使用这个工具，除了预览游戏效果以外，也可以随时修改脚本。
是游戏开发过程中，完全可以放弃AVGreader的存在的一个比较轻便的工具。

**它有两个图形预览窗口。**
一个用了几个VS2005提供的控件，优点在于速度快，缺点在于不支持半透明的png资源。
一个用了GDI+，优点在于上面的缺点，缺点在于上面的缺点。
正式因为这样的原因，窗体中保留了两个预览窗。

**它具有脚本调试的功能。**
不但可以按顺序执行，还可以单步执行。在单步执行过程中，可以回退、前进。当然这样的操作可能会是脚本阅读出完全不同的效果。