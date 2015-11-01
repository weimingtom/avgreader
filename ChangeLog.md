#How it grows...
Write down how it grows, step by step...

## 2009-2-17 [r15](https://code.google.com/p/avgreader/source/detail?r=15) ##
  * 将工程转换为visual studio 2008

## 2009-2-17 [r14](https://code.google.com/p/avgreader/source/detail?r=14) ##
  * 使用DirectX SDK (November 2008)重新编译AVGreader.exe

## 2009-1-11 [r12](https://code.google.com/p/avgreader/source/detail?r=12) ##

> #### AVGreader.exe ####
  * 采用新方法读取脚本（ScriptReader中已经使用的方法）
  * 将所有纹理的布局改成了宽屏的。（昨天遗留的问题）
> #### resources 资源 ####
  * 改变背景图为960\*540。
  * 改变角色图为540\*315。
  * 改变frame为611\*270。

## 2009-1-10 [r9](https://code.google.com/p/avgreader/source/detail?r=9) ##

> #### ScriptReader ####
  * 两个预览缩略图全部改成了16:9。
  * 在GDI+的预览缩略图中加入了frame的显示（速度更慢了）。
  * 读取场景(SCENE)文件时改成了读.JPG。
> #### AVGreader ####
  * 将窗口大小（客户区域）改为960\*540，但没有修改其他任何应该被调整的代码。
  * 读取场景(SCENE)文件时改成了读.JPG。
> #### resources 资源 ####
  * 加入10个.JPG的背景图，也保留了原来的bmp格式。

## 2008-12-16 [r8](https://code.google.com/p/avgreader/source/detail?r=8) ##
  * 上传了之前的工作。