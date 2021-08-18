public override void userCode(sisiAPIint api) {
   sb.mainText="Batch";
   //addVarText(vars[vid]);
   //vars[vid3].val=vars[vid1].val/vars[vid2].val;

api.con.clear();

//start batch simulations:
int NumScen=3;  //number of scenarios simulated
for (int scen=0; scen<NumScen; scen++) {


//C:\Users\chaim\SIMBA#


//get flows and concentrstions input files:


	int Scenario=scen+1; 
         
	int Index = 34; // number of input files
	for (int i=1; i<=Index; i++){
		string template = "InputHS{0}";  //The input files names are InputHS with an aditional number for each file (InputHS1, InputHS2, InputHS3 etc.,..). doing it this way because thought needed to add text after the number ("InputHS{0}.text") in this case could also be the following short string filename = "InputHS"+i.ToString()

		string data = i.ToString();
		string fileName  = string.Format(template, data);

            	//string sourcePath = @"C:\Users\Roni Penn\Dropbox\ISP\ISP\" + Scenario.ToString();  //" + Scenario.ToString() using string.Format the last folder will later change to the coresponding folder of the corsponding scenario simulated
            	string sourcePath = @"C:\Users\chaim\SIMBA#\SCEN" + Scenario.ToString();  //" + Scenario.ToString() using string.Format the last folder will later change to the coresponding folder of the corsponding scenario simulated


            	string targetPath =  @"C:\\Users\chaim\SIMBA#\main";

            	// Use Path class to manipulate file and directory paths.
            	string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            	string destFile = System.IO.Path.Combine(targetPath, fileName);

            	// To copy a file to another location and 
            	// overwrite the destination file if it already exists.
            	System.IO.File.Copy(sourceFile, destFile, true);
            
            
 
    }    

// call simulaion:
      api.createModel();
      api.prepareSim(0.0, 2); //start and end time of simulation
      while(true) {
         if (api.step()) break;
         api.updateGui();
      }
      // user stop!
      if (api.isSimError()) return;

// get simulation results


// FLOW RESULTS:
matrix y1Q=api.getResultMatrix("SWMM Model/SWMM","L_1_Flow");
matrix y9Q=api.getResultMatrix("SWMM Model/SWMM","L_9_Flow");
matrix y18Q=api.getResultMatrix("SWMM Model/SWMM","L_18_Flow");
matrix y22Q=api.getResultMatrix("SWMM Model/SWMM","L_22_Flow");
matrix y13Q=api.getResultMatrix("SWMM Model/SWMM","L_13_Flow");
matrix y24Q=api.getResultMatrix("SWMM Model/SWMM","L_24_Flow");
matrix y28Q=api.getResultMatrix("SWMM Model/SWMM","L_28_Flow");
matrix y17Q=api.getResultMatrix("SWMM Model/SWMM","L_17_Flow");
matrix y30Q=api.getResultMatrix("SWMM Model/SWMM","L_30_Flow");
matrix y36Q=api.getResultMatrix("SWMM Model/SWMM","L_36_Flow");
matrix y43Q=api.getResultMatrix("SWMM Model/SWMM","L_43_Flow");
matrix y47Q=api.getResultMatrix("SWMM Model/SWMM","L_47_Flow");
matrix y48Q=api.getResultMatrix("SWMM Model/SWMM","L_48_Flow");
matrix y63Q=api.getResultMatrix("SWMM Model/SWMM","L_63_Flow");
matrix y64Q=api.getResultMatrix("SWMM Model/SWMM","L_64_Flow");
matrix y70Q=api.getResultMatrix("SWMM Model/SWMM","L_70_Flow");
matrix y65Q=api.getResultMatrix("SWMM Model/SWMM","L_65_Flow");
matrix y52Q=api.getResultMatrix("SWMM Model/SWMM","L_52_Flow");
matrix y54Q=api.getResultMatrix("SWMM Model/SWMM","L_54_Flow");
matrix y58Q=api.getResultMatrix("SWMM Model/SWMM","L_58_Flow");
matrix y86Q=api.getResultMatrix("SWMM Model/SWMM","L_86_Flow");
matrix y87Q=api.getResultMatrix("SWMM Model/SWMM","L_87_Flow");
matrix y89Q=api.getResultMatrix("SWMM Model/SWMM","L_89_Flow");
matrix y130Q=api.getResultMatrix("SWMM Model/SWMM","L_130_Flow");
matrix y134Q=api.getResultMatrix("SWMM Model/SWMM","L_134_Flow");
matrix y135Q=api.getResultMatrix("SWMM Model/SWMM","L_135_Flow");
matrix y141Q=api.getResultMatrix("SWMM Model/SWMM","L_141_Flow");
matrix y145Q=api.getResultMatrix("SWMM Model/SWMM","L_145_Flow");
matrix y147Q=api.getResultMatrix("SWMM Model/SWMM","L_147_Flow");
matrix y151Q=api.getResultMatrix("SWMM Model/SWMM","L_151_Flow");
matrix y94Q=api.getResultMatrix("SWMM Model/SWMM","L_94_Flow");
matrix y97Q=api.getResultMatrix("SWMM Model/SWMM","L_97_Flow");
matrix y102Q=api.getResultMatrix("SWMM Model/SWMM","L_102_Flow");
matrix y108Q=api.getResultMatrix("SWMM Model/SWMM","L_108_Flow");
matrix y112Q=api.getResultMatrix("SWMM Model/SWMM","L_112_Flow");
matrix y118Q=api.getResultMatrix("SWMM Model/SWMM","L_118_Flow");
matrix y125Q=api.getResultMatrix("SWMM Model/SWMM","L_125_Flow");
matrix y122Q=api.getResultMatrix("SWMM Model/SWMM","L_122_Flow");
//matrix y124Q=api.getResultMatrix("SWMM Model/SWMM","L_124_Flow");
matrix y109Q=api.getResultMatrix("SWMM Model/SWMM","L_109_Flow");
matrix y72Q=api.getResultMatrix("SWMM Model/SWMM","L_72_Flow");
matrix y74Q=api.getResultMatrix("SWMM Model/SWMM","L_74_Flow");
matrix y85Q=api.getResultMatrix("SWMM Model/SWMM","L_85_Flow");
matrix y154Q=api.getResultMatrix("SWMM Model/SWMM","L_154_Flow");


// VELOCITY RESULTS:
matrix y1V=api.getResultMatrix("SWMM Model/SWMM","L_1_Velocity");
matrix y9V=api.getResultMatrix("SWMM Model/SWMM","L_9_Velocity");
matrix y18V=api.getResultMatrix("SWMM Model/SWMM","L_18_Velocity");
matrix y22V=api.getResultMatrix("SWMM Model/SWMM","L_22_Velocity");
matrix y13V=api.getResultMatrix("SWMM Model/SWMM","L_13_Velocity");
matrix y24V=api.getResultMatrix("SWMM Model/SWMM","L_24_Velocity");
matrix y28V=api.getResultMatrix("SWMM Model/SWMM","L_28_Velocity");
matrix y17V=api.getResultMatrix("SWMM Model/SWMM","L_17_Velocity");
matrix y30V=api.getResultMatrix("SWMM Model/SWMM","L_30_Velocity");
matrix y36V=api.getResultMatrix("SWMM Model/SWMM","L_36_Velocity");
matrix y43V=api.getResultMatrix("SWMM Model/SWMM","L_43_Velocity");
matrix y47V=api.getResultMatrix("SWMM Model/SWMM","L_47_Velocity");
matrix y48V=api.getResultMatrix("SWMM Model/SWMM","L_48_Velocity");
matrix y63V=api.getResultMatrix("SWMM Model/SWMM","L_63_Velocity");
matrix y64V=api.getResultMatrix("SWMM Model/SWMM","L_64_Velocity");
matrix y70V=api.getResultMatrix("SWMM Model/SWMM","L_70_Velocity");
matrix y65V=api.getResultMatrix("SWMM Model/SWMM","L_65_Velocity");
matrix y52V=api.getResultMatrix("SWMM Model/SWMM","L_52_Velocity");
matrix y54V=api.getResultMatrix("SWMM Model/SWMM","L_54_Velocity");
matrix y58V=api.getResultMatrix("SWMM Model/SWMM","L_58_Velocity");
matrix y86V=api.getResultMatrix("SWMM Model/SWMM","L_86_Velocity");
matrix y87V=api.getResultMatrix("SWMM Model/SWMM","L_87_Velocity");
matrix y89V=api.getResultMatrix("SWMM Model/SWMM","L_89_Velocity");
matrix y130V=api.getResultMatrix("SWMM Model/SWMM","L_130_Velocity");
matrix y134V=api.getResultMatrix("SWMM Model/SWMM","L_134_Velocity");
matrix y135V=api.getResultMatrix("SWMM Model/SWMM","L_135_Velocity");
matrix y141V=api.getResultMatrix("SWMM Model/SWMM","L_141_Velocity");
matrix y145V=api.getResultMatrix("SWMM Model/SWMM","L_145_Velocity");
matrix y147V=api.getResultMatrix("SWMM Model/SWMM","L_147_Velocity");
matrix y151V=api.getResultMatrix("SWMM Model/SWMM","L_151_Velocity");
matrix y94V=api.getResultMatrix("SWMM Model/SWMM","L_94_Velocity");
matrix y97V=api.getResultMatrix("SWMM Model/SWMM","L_97_Velocity");
matrix y102V=api.getResultMatrix("SWMM Model/SWMM","L_102_Velocity");
matrix y108V=api.getResultMatrix("SWMM Model/SWMM","L_108_Velocity");
matrix y112V=api.getResultMatrix("SWMM Model/SWMM","L_112_Velocity");
matrix y118V=api.getResultMatrix("SWMM Model/SWMM","L_118_Velocity");
matrix y125V=api.getResultMatrix("SWMM Model/SWMM","L_125_Velocity");
matrix y122V=api.getResultMatrix("SWMM Model/SWMM","L_122_Velocity");
//matrix y124V=api.getResultMatrix("SWMM Model/SWMM","L_124_Velocity");
matrix y109V=api.getResultMatrix("SWMM Model/SWMM","L_109_Velocity");
matrix y72V=api.getResultMatrix("SWMM Model/SWMM","L_72_Velocity");
matrix y74V=api.getResultMatrix("SWMM Model/SWMM","L_74_Velocity");
matrix y85V=api.getResultMatrix("SWMM Model/SWMM","L_85_Velocity");
matrix y154V=api.getResultMatrix("SWMM Model/SWMM","L_154_Velocity");

// WATER DEPTH RESULTS:
matrix y1D=api.getResultMatrix("SWMM Model/SWMM","L_1_Depth");
matrix y9D=api.getResultMatrix("SWMM Model/SWMM","L_9_Depth");
matrix y18D=api.getResultMatrix("SWMM Model/SWMM","L_18_Depth");
matrix y22D=api.getResultMatrix("SWMM Model/SWMM","L_22_Depth");
matrix y13D=api.getResultMatrix("SWMM Model/SWMM","L_13_Depth");
matrix y24D=api.getResultMatrix("SWMM Model/SWMM","L_24_Depth");
matrix y28D=api.getResultMatrix("SWMM Model/SWMM","L_28_Depth");
matrix y17D=api.getResultMatrix("SWMM Model/SWMM","L_17_Depth");
matrix y30D=api.getResultMatrix("SWMM Model/SWMM","L_30_Depth");
matrix y36D=api.getResultMatrix("SWMM Model/SWMM","L_36_Depth");
matrix y43D=api.getResultMatrix("SWMM Model/SWMM","L_43_Depth");
matrix y47D=api.getResultMatrix("SWMM Model/SWMM","L_47_Depth");
matrix y48D=api.getResultMatrix("SWMM Model/SWMM","L_48_Depth");
matrix y63D=api.getResultMatrix("SWMM Model/SWMM","L_63_Depth");
matrix y64D=api.getResultMatrix("SWMM Model/SWMM","L_64_Depth");
matrix y70D=api.getResultMatrix("SWMM Model/SWMM","L_70_Depth");
matrix y65D=api.getResultMatrix("SWMM Model/SWMM","L_65_Depth");
matrix y52D=api.getResultMatrix("SWMM Model/SWMM","L_52_Depth");
matrix y54D=api.getResultMatrix("SWMM Model/SWMM","L_54_Depth");
matrix y58D=api.getResultMatrix("SWMM Model/SWMM","L_58_Depth");
matrix y86D=api.getResultMatrix("SWMM Model/SWMM","L_86_Depth");
matrix y87D=api.getResultMatrix("SWMM Model/SWMM","L_87_Depth");
matrix y89D=api.getResultMatrix("SWMM Model/SWMM","L_89_Depth");
matrix y130D=api.getResultMatrix("SWMM Model/SWMM","L_130_Depth");
matrix y134D=api.getResultMatrix("SWMM Model/SWMM","L_134_Depth");
matrix y135D=api.getResultMatrix("SWMM Model/SWMM","L_135_Depth");
matrix y141D=api.getResultMatrix("SWMM Model/SWMM","L_141_Depth");
matrix y145D=api.getResultMatrix("SWMM Model/SWMM","L_145_Depth");
matrix y147D=api.getResultMatrix("SWMM Model/SWMM","L_147_Depth");
matrix y151D=api.getResultMatrix("SWMM Model/SWMM","L_151_Depth");
matrix y94D=api.getResultMatrix("SWMM Model/SWMM","L_94_Depth");
matrix y97D=api.getResultMatrix("SWMM Model/SWMM","L_97_Depth");
matrix y102D=api.getResultMatrix("SWMM Model/SWMM","L_102_Depth");
matrix y108D=api.getResultMatrix("SWMM Model/SWMM","L_108_Depth");
matrix y112D=api.getResultMatrix("SWMM Model/SWMM","L_112_Depth");
matrix y118D=api.getResultMatrix("SWMM Model/SWMM","L_118_Depth");
matrix y125D=api.getResultMatrix("SWMM Model/SWMM","L_125_Depth");
matrix y122D=api.getResultMatrix("SWMM Model/SWMM","L_122_Depth");
//matrix y124D=api.getResultMatrix("SWMM Model/SWMM","L_124_Depth");
matrix y109D=api.getResultMatrix("SWMM Model/SWMM","L_109_Depth");
matrix y72D=api.getResultMatrix("SWMM Model/SWMM","L_72_Depth");
matrix y74D=api.getResultMatrix("SWMM Model/SWMM","L_74_Depth");
matrix y85D=api.getResultMatrix("SWMM Model/SWMM","L_85_Depth");
matrix y154D=api.getResultMatrix("SWMM Model/SWMM","L_154_Depth");

//matrix y= api.getResultMatrix("swmm","L_Redbud_Flow"); from Manfreds example.

//save flow in a text file
	using (System.IO.StreamWriter file = new System.IO.StreamWriter("SWMMFlowRS.txt")) {
      for (int i=0; i<y1Q.mrow; i++) {
	//the file has 2 columns first the coresponding time, second results from the first column in y
         file.WriteLine(
		aConv.double2string(y1Q[i,0])  + ", " +
		aConv.double2string(y1Q[i,1])  + ", " + aConv.double2string(y9Q[i,1])  + ", " + aConv.double2string(y18Q[i,1]) + ", " + aConv.double2string(y22Q[i,1]) + ", " + aConv.double2string(y13Q[i,1]) + ", " + aConv.double2string(y24Q[i,1]) + ", " + aConv.double2string(y28Q[i,1]) + ", " + aConv.double2string(y17Q[i,1]) + ", " + aConv.double2string(y30Q[i,1]) + ", " +               aConv.double2string(y36Q[i,1]) + ", " +aConv.double2string(y43Q[i,1])+ ", " +aConv.double2string(y47Q[i,1])+", "+aConv.double2string(y48Q[i,1])+", "+aConv.double2string(y63Q[i,1])+", "+aConv.double2string(y64Q[i,1])+", "+aConv.double2string(y70Q[i,1])+", "+aConv.double2string(y65Q[i,1])+", "+aConv.double2string(y52Q[i,1])+", "+aConv.double2string(y54Q[i,1])+", "+aConv.double2string(y58Q[i,1])+", "+aConv.double2string(y86Q[i,1])+", "+aConv.double2string(y87Q[i,1])+", "+aConv.double2string(y89Q[i,1])+", "+aConv.double2string(y130Q[i,1])+", "+aConv.double2string(y134Q[i,1])+", "+aConv.double2string(y135Q[i,1])+", "+aConv.double2string(y141Q[i,1])+", "+aConv.double2string(y145Q[i,1])+", "+aConv.double2string(y147Q[i,1])+", "+aConv.double2string(y151Q[i,1])+", "+aConv.double2string(y94Q[i,1])+", "+aConv.double2string(y97Q[i,1])+", "+aConv.double2string(y102Q[i,1])+", "+aConv.double2string(y108Q[i,1])+", "+aConv.double2string(y112Q[i,1])+", "+aConv.double2string(y118Q[i,1])+", "+aConv.double2string(y125Q[i,1])+", "+aConv.double2string(y122Q[i,1])+", "+aConv.double2string(y109Q[i,1])+", "+aConv.double2string(y72Q[i,1])+", "+aConv.double2string(y74Q[i,1])+", "+aConv.double2string(y85Q[i,1])+", "+aConv.double2string(y154Q[i,1]));  	

	//file.WriteLine("t="+aConv.double2string(y[i,0])+", "+aConv.double2string(y[i,1])+", "+aConv.double2string(y2[i,1]));
      }


//get some parameters
//string Vol=api.getParam("Nitri", "Vol") ;
//api.con.writeLn("Vol Nitri="+Vol);
}

//save velocity in a text file

using (System.IO.StreamWriter file = new System.IO.StreamWriter("SWMMVelocityRS.txt")) {
      for (int i=0; i<y1Q.mrow; i++) {
	//the file has 2 columns first the coresponding time, second results from the first column in y

         file.WriteLine(aConv.double2string(y1V[i,0])+ ", " +
		 aConv.double2string(y1V[i,1])+ ", "+aConv.double2string(y9V[i,1])+", "+aConv.double2string(y18V[i,1])+", "+aConv.double2string(y22V[i,1])+", "+aConv.double2string(y13V[i,1])+", "+aConv.double2string(y24V[i,1])+", "+aConv.double2string(y28V[i,1])+", "+aConv.double2string(y17V[i,1])+", "+aConv.double2string(y30V[i,1])+", "+aConv.double2string(y36V[i,1])+", "+aConv.double2string(y43V[i,1])+", "+aConv.double2string(y47V[i,1])+", "+aConv.double2string(y48V[i,1])+", "+aConv.double2string(y63V[i,1])+", "+aConv.double2string(y64V[i,1])+", "+aConv.double2string(y70V[i,1])+", "+aConv.double2string(y65V[i,1])+", "+aConv.double2string(y52V[i,1])+", "+aConv.double2string(y54V[i,1])+", "+aConv.double2string(y58V[i,1])+", "+aConv.double2string(y86V[i,1])+", "+aConv.double2string(y87V[i,1])+", "+aConv.double2string(y89V[i,1])+", "+aConv.double2string(y130V[i,1])+", "+aConv.double2string(y134V[i,1])+", "+aConv.double2string(y135V[i,1])+", "+aConv.double2string(y141V[i,1])+", "+aConv.double2string(y145V[i,1])+", "+aConv.double2string(y147V[i,1])+", "+aConv.double2string(y151V[i,1])+", "+aConv.double2string(y94V[i,1])+", "+aConv.double2string(y97V[i,1])+", "+aConv.double2string(y102V[i,1])+", "+aConv.double2string(y108V[i,1])+", "+aConv.double2string(y112V[i,1])+", "+aConv.double2string(y118V[i,1])+", "+aConv.double2string(y125V[i,1])+", "+aConv.double2string(y122V[i,1])+", "+aConv.double2string(y109V[i,1])+", "+aConv.double2string(y72V[i,1])+", "+aConv.double2string(y74V[i,1])+", "+aConv.double2string(y85V[i,1])+", "+aConv.double2string(y154V[i,1]));  

	
      }


}


//save water depth in a text file

using (System.IO.StreamWriter file = new System.IO.StreamWriter("SWMMDepthRS.txt")) {
      for (int i=0; i<y1Q.mrow; i++) {
	//the file has 2 columns first the coresponding time, second results from the first column in y

         file.WriteLine(aConv.double2string(y1D[i,0])+ ", " +
		 aConv.double2string(y1D[i,1])+ ", "+aConv.double2string(y9D[i,1])+", "+aConv.double2string(y18D[i,1])+", "+aConv.double2string(y22D[i,1])+", "+aConv.double2string(y13D[i,1])+", "+aConv.double2string(y24D[i,1])+", "+aConv.double2string(y28D[i,1])+", "+aConv.double2string(y17D[i,1])+", "+aConv.double2string(y30D[i,1])+", "+aConv.double2string(y36D[i,1])+", "+aConv.double2string(y43D[i,1])+", "+aConv.double2string(y47D[i,1])+", "+aConv.double2string(y48D[i,1])+", "+aConv.double2string(y63D[i,1])+", "+aConv.double2string(y64D[i,1])+", "+aConv.double2string(y70D[i,1])+", "+aConv.double2string(y65D[i,1])+", "+aConv.double2string(y52D[i,1])+", "+aConv.double2string(y54D[i,1])+", "+aConv.double2string(y58D[i,1])+", "+aConv.double2string(y86D[i,1])+", "+aConv.double2string(y87D[i,1])+", "+aConv.double2string(y89D[i,1])+", "+aConv.double2string(y130D[i,1])+", "+aConv.double2string(y134D[i,1])+", "+aConv.double2string(y135D[i,1])+", "+aConv.double2string(y141D[i,1])+", "+aConv.double2string(y145D[i,1])+", "+aConv.double2string(y147D[i,1])+", "+aConv.double2string(y151D[i,1])+", "+aConv.double2string(y94D[i,1])+", "+aConv.double2string(y97D[i,1])+", "+aConv.double2string(y102D[i,1])+", "+aConv.double2string(y108D[i,1])+", "+aConv.double2string(y112D[i,1])+", "+aConv.double2string(y118D[i,1])+", "+aConv.double2string(y125D[i,1])+", "+aConv.double2string(y122D[i,1])+", "+aConv.double2string(y109D[i,1])+", "+aConv.double2string(y72D[i,1])+", "+aConv.double2string(y74D[i,1])+", "+aConv.double2string(y85D[i,1])+", "+aConv.double2string(y154D[i,1]));  
      }

}

//C:\Users\chaim\SIMBA#


//save the result text files in the coresponding scenario folder:


string fileNameSWMMFlowRS  = "SWMMFlowRS.txt";
		  
            string sourcePathSWMMFlowRS = @"C:\Users\chaim\SIMBA#\main";
            string targetPathSWMMFlowRS =  @"C:\Users\chaim\SIMBA#\SCEN" + Scenario.ToString();  //using string.Format the last folder will later change to the coresponding folder of the corsponding scenario simulated

            // Use Path class to manipulate file and directory paths.
            string sourceFileSWMMFlowRS = System.IO.Path.Combine(sourcePathSWMMFlowRS, fileNameSWMMFlowRS);
            string destFileSWMMFlowRS = System.IO.Path.Combine(targetPathSWMMFlowRS, fileNameSWMMFlowRS);

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFileSWMMFlowRS, destFileSWMMFlowRS, true);





 string fileNameSWMMVelocityRS  = "SWMMVelocityRS.txt";
		  
            string sourcePathSWMMVelocityRS = @"C:\Users\chaim\SIMBA#\main";

            string targetPathSWMMVelocityRS =  @"C:\Users\chaim\SIMBA#\SCEN" + Scenario.ToString();  //using string.Format the last folder will later change to the coresponding folder of the corsponding scenario simulated

            // Use Path class to manipulate file and directory paths.
            string sourceFileSWMMVelocityRS = System.IO.Path.Combine(sourcePathSWMMVelocityRS, fileNameSWMMVelocityRS);
            string destFileSWMMVelocityRS = System.IO.Path.Combine(targetPathSWMMVelocityRS, fileNameSWMMVelocityRS);

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFileSWMMVelocityRS, destFileSWMMVelocityRS, true);


 string fileNameSWMMDepthRS  = "SWMMDepthRS.txt";
		  
            string sourcePathSWMMDepthRS = @"C:\Users\chaim\SIMBA#\main";

            string targetPathSWMMDepthRS =  @"C:\Users\chaim\SIMBA#\SCEN" + Scenario.ToString();  //using string.Format the last folder will later change to the coresponding folder of the corsponding scenario simulated

            // Use Path class to manipulate file and directory paths.
            string sourceFileSWMMDepthRS = System.IO.Path.Combine(sourcePathSWMMDepthRS, fileNameSWMMDepthRS);
            string destFileSWMMDepthRS = System.IO.Path.Combine(targetPathSWMMDepthRS, fileNameSWMMDepthRS);

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFileSWMMDepthRS, destFileSWMMDepthRS, true);





} //closing Batch
} //closing script







