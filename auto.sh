#!/bin/bash
uuid=0
teamid='a'
gameid='a'
for i in $(cat app_logs|grep fund|awk '{print $7}')
do
   if [ $uuid != $i ];then
   echo $i
   uuid=$i
   res=`curl -i -H "Accept: application/json" -X POST -d '{"game":"'"$gameid"'", "team":"'"$teamid"'", "order":"'"$uuid"'"}' https://stats.aws.dev-null.link/proc/refund`
   echo $res
   fi
done
