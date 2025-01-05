# aspire-yarp-reverse-proxy

Dotnet Aspire ve YARP kullanarak birden fazla SPA (React) application'ın tek host üzerinde yayınlanmasını gösteren bir PoC.

TODO List:

* Aspir8 ile k8s'e deploy edip çalışıyor mu kontrol edilecek
* API ve appler public olmamalıydı, sadece dev ortamda mı bu şekilde çalışıyor kontrol edilecek
* ReverseProxy configuration'daki servis adresi environment settings içinden alınacak
* IdentityServer ile çalışır mı? Blocking bir issue çıkar mı kontrol edilecek (Self-Hosted, Auth0, Microsoft Entra ID)