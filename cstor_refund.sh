#!/bin/bash
cd /root
#cat server.log |grep Refund >> sva.log
cat server.log >>  server_bak.log
echo "" > server.log
sh=`cat server_bak.log |awk '!a[$0]++{print $6}'`
for i in $sh;do
body="{\"user_id\":\"$1\",\"game_id\":\"$2\",\"refund_id\":\"$i\"}"
curl -i -H "Accept: application/json" -X POST -d $body http://onlyellow.cstor.cn:18888/refund
done
