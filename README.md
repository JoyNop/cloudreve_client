# cloudreve_client

![logo_white.png](https://raw.githubusercontent.com/HFO4/Cloudreve/master/static/img/logo_white.png)

Cloudreve - Make the cloud easy for everyone
=========================
[![Packagist](https://img.shields.io/packagist/v/HFO4/Cloudreve.svg)](https://packagist.org/packages/hfo4/cloudreve)
[![Latest Unstable Version](https://poser.pugx.org/hfo4/cloudreve/v/unstable)](https://packagist.org/packages/hfo4/cloudreve)
[![License](https://poser.pugx.org/hfo4/cloudreve/license)](https://packagist.org/packages/hfo4/cloudreve)

 

基于ThinkPHP构建的网盘系统，能够助您以较低成本快速搭建起公私兼备的网盘。

![homepage.png](https://download.aoaoao.me/homepage-linux.png)

目前已经实现的特性：

* 快速对接多家云存储，支持七牛、又拍云、阿里云OSS、AWS S3、自建远程服务器，当然，还有本地存储
* 可限制单文件最大大小、MIMEType、文件后缀、用户可用容量
* 基于Aria2的离线下载
* 图片、音频、视频、文本、Markdown、Ofiice文档 在线预览
* 移动端全站响应式布局
* 文件、目录分享系统，可创建私有分享或公开分享链接
* 用户个人主页，可查看用户所有分享
* 多用户系统、用户组支持
* 初步完善的后台，方便管理
* 拖拽上传、分片上传、断点续传、下载限速（*实验性功能）
* 多上传策略，可为不同用户组分配不同策略
* 用户组基础权限设置、二步验证
* WebDAV协议支持

To-do:

* - [ ] 重写目录分享和单文件分享页面样式
* - [ ] 增加保存其他用户的分享到自己账户（限Pro版）
* - [ ] 推出辅助程序GoDriver,用于驱动php或客户端实现不了的功能，并借此实现:
   * - [ ] 压缩包解压缩、文件压缩
   * - [ ] 对接Ondrive、Google Drive,上传模式为先上到自己服务器，然后由GoDriver中转
* - [ ] 用Golang重写的远程服务端

 
   ___ _                 _                    
  / __\ | ___  _   _  __| |_ __ _____   _____ 
 / /  | |/ _ \| | | |/ _` | '__/ _ \ \ / / _ \
/ /___| | (_) | |_| | (_| | | |  __/\ V /  __/
\____/|_|\___/ \__,_|\__,_|_|  \___| \_/ \___|
        
                
================================================
 
* 给本项目一个Star~

 

许可证
------------
GPLV3
