使用说明：

在asset根目录创建Art文件夹，Art下创建子文件夹ABSingleFile，下面的文件会以文件单位处理ab包名字
其他资源建议分类创建文件夹，控制颗粒粗细度，会自动以文件为单位处理ab包名字
注意：Art下不要有resource文件夹

直接使用文件名进行加载ab中资源

1、初始化ResKit.Init();
2、ResLoader resLoader =  ResLoader.Allocate(); 申请资源加载器
3、同步加载：resLoader.LoadSync("res_name");
4、异步加载：resLoader.Add2Load("res_name",callback); 可以添加多个，统一通过resLoader.LoadAsync();开启异步加载
5、资源不再使用后记得手动调用resLoader.ReleaseRes("res_name");释放资源内存
6、resloader不再使用，手动调用resLoader.Recycle2Cache();回收resloader对象池