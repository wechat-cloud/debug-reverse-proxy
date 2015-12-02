# debug-reverse-proxy

Because Wechat MP required 80 port during forward message occur in MP, so it is hard to build up internal testing server.

This tiny project is used to build up reverse proxy server for testing purpose.

Simply speaking, wechat server will community with third-party free hosting services, which is running this component, then component will establish external connection by configuration and return to original requester(wechat server).

```
Wechat Server <-----> Third-Party <-----component-----> internal or non-80 port services
```

Usage
-----

Access Point: `~/ReverseProxy/Site/{site-base64-string}`

e.g. use https://www.base64encode.org/ to get base64 string of your internal or non-80 port service.
