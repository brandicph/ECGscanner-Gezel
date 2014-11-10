echo Merging files;
#cat *.fdl > program.fdl;

cat settings.fdl PC.fdl IM.fdl CTRL.fdl REG.fdl ALU.fdl AND.fdl OR.fdl CPU.fdl > program.fdl;

echo Start Gezel Simulation;
fdlsim program.fdl 3230;
#gtkwave TRACE.vcd &
#fdlvhd counter.fdl