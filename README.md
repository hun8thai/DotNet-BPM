# DotNet-BPM

## Oralce

sqlplus / AS SYSDBA
sqlplus sys as sysdba
connect sys/oracle@localhost:1521/orclpxe as sysdba
alter pluggable database ORCLPXE open read write;

Oracle info
XE - sys - 123456
ORCLPXE - BPM_SOAINFRA - ORCLPXE
XE - MKBATCHP - MKBATCHP

## Start and config BPM project
cmd.exe /c "D:\Oracle\Middleware\Oracle_Home\oracle_common\common\bin\wlst.cmd" "C:\Users\hungtq\AppData\Roaming\JDeveloper\system12.2.1.4.42.190911.2248\o.j2ee.adrs\BuildDefaultDomain1.py"

"D:\Oracle\Middleware\Oracle_Home\oracle_common\common\bin\wlst.cmd" "C:\Users\hungtq\AppData\Roaming\JDeveloper\system12.2.1.4.42.190911.2248\o.j2ee.adrs\BuildDefaultDomain1.py"

C:\Users\hungtq\AppData\Roaming\JDeveloper\system12.2.1.4.42.190911.2248\DefaultDomain\bin\startWebLogic.cmd

https://docs.oracle.com/middleware/1213/core/INSOA/configure_bpm.htm#INSOA466

D:\Oracle\Middleware\Oracle_Home\user_projects\domains\base_domain\bin\startWebLogic.cmd
%DOMAIN_HOME%/bin/startWebLogic.cmd


CREATE or REPLACE trigger OPEN_ALL_PLUGGABLES after startup  on  database BEGIN execute immediate 'alter pluggable database all open'; END open_all_pdbs;