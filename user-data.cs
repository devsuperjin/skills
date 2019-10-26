#!/bin/bash
sleep 10
yum install memcached -y
systemctl start memcached
wget http://onlyellow.cstor.cn/q4/server_route_v1 -O /root/server_route_v1
wget http://onlyellow.cstor.cn/q4/conf.toml -O /root/conf.toml
cd /root
sed -i 's/memcache_host ="127.0.0.1"/memcache_host ="rou.j2u8sc.0001.cnw1.cache.amazonaws.com.cn"/g' /root/conf.toml
chmod +x server_route_v1
nohup ./server_route_v1 conf.toml &

---------------------

#!/bin/bash
sleep 5
wget http://onlyellow.cstor.cn/q4/server_route_v2 -O /root/server_route_v2
wget http://onlyellow.cstor.cn/q4/conf.toml -O /root/conf.toml
cd /root
sed -i 's/memcache_host ="127.0.0.1"/memcache_host ="rou.j2u8sc.0001.cnw1.cache.amazonaws.com.cn"/g' /root/conf.toml
chmod +x server_route_v2
nohup ./server_route_v2 conf.toml &

-------------------------------
