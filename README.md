# CSharp-Template-for-Algorithm-Competition

## 一、IDE

**VS2026**

## 二、模板库

来自CSharp版本的atc模板库：https://github.com/kzrnm/ac-library-csharp

## 三、如何使用

### 3.1 安装 SourceExpander

在 VS2026 中打开管理NuGet包安装SourceExpander 这个包

![image-20260113214704427](.\pics\image-20260113214704427.png)

### 3.2 安装 ac-library-csharp

同样的，找到 ac-library-csharp 包并安装

![image-20260113214800761](.\pics\image-20260113214800761.png)

### 3.3 在本地使用atc模板库

![image-20260113214900000](.\pics\image-20260113214900000.png)

装完上面两个包，就可以正常使用 atc的板子了。

在主程序中加入 `            SourceExpander.Expander.Expand();`

这样运行后就会生成一个 文件`Combined.csx`， SourceExpander 会在该文件尾部帮你展开你所引用的命名空间

![image-20260113215117969](.\pics\image-20260113215117969.png)

### 3.4 如何展开自定义库

#### 3.4.1 创建自定义类库

自己在VS中新建个项目，把想要添加的类定义放里面

比如我的IO板子：

![image-20260113215345854](.\pics\image-20260113215345854.png)

#### 3.4.2 安装 SourceExpander.Embedder

这次安装：**SourceExpander.Embedder**（**注意，在类库项目中安装，如果同时安装SourceExpander 和 SourceExpander.Embedder无法正常运行**）

![image-20260113215222465](.\pics\image-20260113215222465.png)

然后在右侧解决方案处右键项目点击生成

![image-20260113215538811](.\pics\image-20260113215538811.png)

这样目录下面会有dll文件，回到写代码的项目，右键点击添加-项目引用

![image-20260113215641742](.\pics\image-20260113215641742.png)

点击浏览，找到dll文件，然后就可以引用类库的内容了

### 3.5 利用反射创建模板代码文件

就是写完A题，让脚本自动帮你创建B题的文件：Templates/Entry.cs

具体可以看Entry.cs 和 Template.cs代码

### 3.6 利用VS单元测试来进行用例测试

VS2026 没有 vscode 那种CPH judge 测试插件，但是VS自带的单元测试已经很方便了

测试脚本：Templates/Test1.cs

具体使用的时候创建一个测试单元的项目，把 Test1.cs 拷贝进去即可

对于每组用例：

DataRow 第一个字符串内放输入，第二个字符串放输出

多组用例直接写多个 DataRow 即可

![image-20260113220031317](.\pics\image-20260113220031317.png)

**效果：**

![image-20260113220448830](.\pics\image-20260113220448830.png)

![image-20260113220513678](.\pics\image-20260113220513678.png)





















