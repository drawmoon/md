# Table of contents

- [CentOS Notes](#centos-notes)
  - [安装 NodeJs](#安装-nodejs)
  - [安装 Yarn](#安装-yarn)
  - [安装 .NET](#安装-net)
  - [安装 Nginx](#安装-nginx)

# CentOS Notes

## 安装 NodeJs

添加 Nodesource 包存储库

```bash
curl --silent --location https://rpm.nodesource.com/setup_10.x | sudo bash -
```

安装 NodeJs

```bash
sudo yum install nodejs
```

安装 Node 管理工具

```bash
npm install -g n
```

安装最新`Stable`版

```bash
n stable
```

## 安装 Yarn

添加 Yarn 包存储库

```bash
curl --silent --location https://dl.yarnpkg.com/rpm/yarn.repo | sudo tee /etc/yum.repos.d/yarn.repo
sudo rpm --import https://dl.yarnpkg.com/rpm/pubkey.gpg
```

安装 Yarn

```bash
sudo yum install yarn
```

## 安装 .NET

添加 Microsoft 包存储库

```bash
sudo rpm -Uvh https://packages.microsoft.com/config/centos/7/packages-microsoft-prod.rpm
```

安装 SDK

```bash
sudo yum install dotnet-sdk-5.0
```

安装 Runtime

```bash
# ASP.NET Core Runtime
sudo yum install aspnetcore-runtime-5.0

# .NET Runtime
sudo yum install dotnet-runtime-5.0
```

## 安装 Nginx

安装依赖包

```bash
sudo yum install gcc pcre-devel zlib-devel openssl openssl-devel make
```

- `gcc`: C 语言编译器
- `pcre-devel`: 正则表达式库
- `zlib-devel`: 数据压缩库
- `openssl`: TLS/SSL 加密库
- `make`: 解释 Makefile 的命令工具

下载 [Nginx](https://nginx.org/en/download.html)，选择 Stable version

解压 Nginx 压缩包

```bash
tar -zxvf nginx-1.18.0.tar.gz
```

执行 Nginx 默认配置

```bash
cd nginx-1.18.0/
./configure
```

执行编译、安装

```bash
# 编译
make

# 安装
sudo make install
```

启动 Nginx

```bash
cd /usr/local/nginx/sbin/
sudo ./nginx
```

验证 Nginx 是否成功启动

```bash
# 查看 Nginx 进程
ps -ef | grep nginx # 如果显示了 Nginx 的进程，说明已经成功启动

# 请求 80 端口
curl http://127.0.0.1 # 如果看到了 Welcome to nginx!，说明已经成功启动
```