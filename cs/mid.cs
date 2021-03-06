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
COMPLETE MATRIX FOR PARAM: FLOW


// VELOCITY RESULTS:
COMPLETE MATRIX FOR PARAM: VELOCITY

// WATER DEPTH RESULTS:
COMPLETE MATRIX FOR PARAM: DEPTH


//save flow in a text file
COMPLETE WRITING FOR PARAM: Flow

//save velocity in a text file
COMPLETE WRITING FOR PARAM: Velocity


//save water depth in a text file
COMPLETE WRITING FOR PARAM: Depth

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







