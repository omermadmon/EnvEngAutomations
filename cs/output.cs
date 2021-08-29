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
matrix y1Q=api.getResultMatrix("SWMM Model/SWMM","L_1last_Flow");
matrix y2Q=api.getResultMatrix("SWMM Model/SWMM","L_2last_Flow");
matrix y3Q=api.getResultMatrix("SWMM Model/SWMM","L_3last_Flow");
matrix y4Q=api.getResultMatrix("SWMM Model/SWMM","L_4last_Flow");
matrix y5Q=api.getResultMatrix("SWMM Model/SWMM","L_5last_Flow");
matrix y6Q=api.getResultMatrix("SWMM Model/SWMM","L_6last_Flow");
matrix y7Q=api.getResultMatrix("SWMM Model/SWMM","L_7last_Flow");
matrix y8Q=api.getResultMatrix("SWMM Model/SWMM","L_8last_Flow");
matrix y9Q=api.getResultMatrix("SWMM Model/SWMM","L_9last_Flow");
matrix y10Q=api.getResultMatrix("SWMM Model/SWMM","L_10last_Flow");
matrix y11Q=api.getResultMatrix("SWMM Model/SWMM","L_11last_Flow");
matrix y12Q=api.getResultMatrix("SWMM Model/SWMM","L_12last_Flow");
matrix y13Q=api.getResultMatrix("SWMM Model/SWMM","L_13last_Flow");
matrix y14Q=api.getResultMatrix("SWMM Model/SWMM","L_14last_Flow");
matrix y15Q=api.getResultMatrix("SWMM Model/SWMM","L_15last_Flow");
matrix y16Q=api.getResultMatrix("SWMM Model/SWMM","L_16last_Flow");
matrix y17Q=api.getResultMatrix("SWMM Model/SWMM","L_17last_Flow");
matrix y18Q=api.getResultMatrix("SWMM Model/SWMM","L_18last_Flow");
matrix y19Q=api.getResultMatrix("SWMM Model/SWMM","L_19last_Flow");
matrix y20Q=api.getResultMatrix("SWMM Model/SWMM","L_20last_Flow");
matrix y21Q=api.getResultMatrix("SWMM Model/SWMM","L_21last_Flow");
matrix y22Q=api.getResultMatrix("SWMM Model/SWMM","L_22last_Flow");
matrix y23Q=api.getResultMatrix("SWMM Model/SWMM","L_23last_Flow");
matrix y24Q=api.getResultMatrix("SWMM Model/SWMM","L_24last_Flow");
matrix y25Q=api.getResultMatrix("SWMM Model/SWMM","L_25last_Flow");
matrix y26Q=api.getResultMatrix("SWMM Model/SWMM","L_26last_Flow");
matrix y27Q=api.getResultMatrix("SWMM Model/SWMM","L_27last_Flow");
matrix y28Q=api.getResultMatrix("SWMM Model/SWMM","L_28last_Flow");
matrix y29Q=api.getResultMatrix("SWMM Model/SWMM","L_29last_Flow");
matrix y30Q=api.getResultMatrix("SWMM Model/SWMM","L_30last_Flow");
matrix y31Q=api.getResultMatrix("SWMM Model/SWMM","L_31last_Flow");
matrix y32Q=api.getResultMatrix("SWMM Model/SWMM","L_32last_Flow");
matrix y33Q=api.getResultMatrix("SWMM Model/SWMM","L_33last_Flow");
matrix y34Q=api.getResultMatrix("SWMM Model/SWMM","L_34last_Flow");
matrix y35Q=api.getResultMatrix("SWMM Model/SWMM","L_35last_Flow");
matrix y36Q=api.getResultMatrix("SWMM Model/SWMM","L_36last_Flow");
matrix y37Q=api.getResultMatrix("SWMM Model/SWMM","L_37last_Flow");
matrix y38Q=api.getResultMatrix("SWMM Model/SWMM","L_38last_Flow");
matrix y39Q=api.getResultMatrix("SWMM Model/SWMM","L_39last_Flow");
matrix y40Q=api.getResultMatrix("SWMM Model/SWMM","L_40last_Flow");
matrix y41Q=api.getResultMatrix("SWMM Model/SWMM","L_41last_Flow");
matrix y42Q=api.getResultMatrix("SWMM Model/SWMM","L_42last_Flow");
matrix y43Q=api.getResultMatrix("SWMM Model/SWMM","L_43last_Flow");
matrix y44Q=api.getResultMatrix("SWMM Model/SWMM","L_44last_Flow");
matrix y45Q=api.getResultMatrix("SWMM Model/SWMM","L_45last_Flow");
matrix y46Q=api.getResultMatrix("SWMM Model/SWMM","L_46last_Flow");
matrix y47Q=api.getResultMatrix("SWMM Model/SWMM","L_47last_Flow");
matrix y48Q=api.getResultMatrix("SWMM Model/SWMM","L_48last_Flow");
matrix y49Q=api.getResultMatrix("SWMM Model/SWMM","L_49last_Flow");
matrix y50Q=api.getResultMatrix("SWMM Model/SWMM","L_50last_Flow");
matrix y51Q=api.getResultMatrix("SWMM Model/SWMM","L_51last_Flow");
matrix y52Q=api.getResultMatrix("SWMM Model/SWMM","L_52last_Flow");
matrix y53Q=api.getResultMatrix("SWMM Model/SWMM","L_53last_Flow");
matrix y54Q=api.getResultMatrix("SWMM Model/SWMM","L_54last_Flow");
matrix y55Q=api.getResultMatrix("SWMM Model/SWMM","L_55last_Flow");
matrix y56Q=api.getResultMatrix("SWMM Model/SWMM","L_56last_Flow");
matrix y57Q=api.getResultMatrix("SWMM Model/SWMM","L_57last_Flow");
matrix y58Q=api.getResultMatrix("SWMM Model/SWMM","L_58last_Flow");
matrix y59Q=api.getResultMatrix("SWMM Model/SWMM","L_59last_Flow");
matrix y60Q=api.getResultMatrix("SWMM Model/SWMM","L_60last_Flow");
matrix y61Q=api.getResultMatrix("SWMM Model/SWMM","L_61last_Flow");
matrix y62Q=api.getResultMatrix("SWMM Model/SWMM","L_62last_Flow");
matrix y63Q=api.getResultMatrix("SWMM Model/SWMM","L_63last_Flow");
matrix y64Q=api.getResultMatrix("SWMM Model/SWMM","L_64last_Flow");
matrix y65Q=api.getResultMatrix("SWMM Model/SWMM","L_65last_Flow");
matrix y66Q=api.getResultMatrix("SWMM Model/SWMM","L_66last_Flow");
matrix y67Q=api.getResultMatrix("SWMM Model/SWMM","L_67last_Flow");
matrix y68Q=api.getResultMatrix("SWMM Model/SWMM","L_68last_Flow");
matrix y69Q=api.getResultMatrix("SWMM Model/SWMM","L_69last_Flow");
matrix y70Q=api.getResultMatrix("SWMM Model/SWMM","L_70last_Flow");
matrix y71Q=api.getResultMatrix("SWMM Model/SWMM","L_71last_Flow");
matrix y72Q=api.getResultMatrix("SWMM Model/SWMM","L_72last_Flow");
matrix y73Q=api.getResultMatrix("SWMM Model/SWMM","L_73last_Flow");
matrix y74Q=api.getResultMatrix("SWMM Model/SWMM","L_74last_Flow");
matrix y75Q=api.getResultMatrix("SWMM Model/SWMM","L_75last_Flow");
matrix y76Q=api.getResultMatrix("SWMM Model/SWMM","L_76last_Flow");
matrix y77Q=api.getResultMatrix("SWMM Model/SWMM","L_77last_Flow");
matrix y78Q=api.getResultMatrix("SWMM Model/SWMM","L_78last_Flow");
matrix y79Q=api.getResultMatrix("SWMM Model/SWMM","L_79last_Flow");
matrix y80Q=api.getResultMatrix("SWMM Model/SWMM","L_80last_Flow");
matrix y81Q=api.getResultMatrix("SWMM Model/SWMM","L_81last_Flow");
matrix y82Q=api.getResultMatrix("SWMM Model/SWMM","L_82last_Flow");
matrix y83Q=api.getResultMatrix("SWMM Model/SWMM","L_83last_Flow");
matrix y84Q=api.getResultMatrix("SWMM Model/SWMM","L_84last_Flow");
matrix y85Q=api.getResultMatrix("SWMM Model/SWMM","L_85last_Flow");
matrix y86Q=api.getResultMatrix("SWMM Model/SWMM","L_86last_Flow");
matrix y87Q=api.getResultMatrix("SWMM Model/SWMM","L_87last_Flow");
matrix y88Q=api.getResultMatrix("SWMM Model/SWMM","L_88last_Flow");
matrix y89Q=api.getResultMatrix("SWMM Model/SWMM","L_89last_Flow");
matrix y90Q=api.getResultMatrix("SWMM Model/SWMM","L_90last_Flow");
matrix y91Q=api.getResultMatrix("SWMM Model/SWMM","L_91last_Flow");
matrix y92Q=api.getResultMatrix("SWMM Model/SWMM","L_92last_Flow");
matrix y93Q=api.getResultMatrix("SWMM Model/SWMM","L_93last_Flow");
matrix y94Q=api.getResultMatrix("SWMM Model/SWMM","L_94last_Flow");
matrix y95Q=api.getResultMatrix("SWMM Model/SWMM","L_95last_Flow");
matrix y96Q=api.getResultMatrix("SWMM Model/SWMM","L_96last_Flow");
matrix y97Q=api.getResultMatrix("SWMM Model/SWMM","L_97last_Flow");
matrix y98Q=api.getResultMatrix("SWMM Model/SWMM","L_98last_Flow");
matrix y99Q=api.getResultMatrix("SWMM Model/SWMM","L_99last_Flow");
matrix y100Q=api.getResultMatrix("SWMM Model/SWMM","L_100last_Flow");
matrix y101Q=api.getResultMatrix("SWMM Model/SWMM","L_101last_Flow");
matrix y102Q=api.getResultMatrix("SWMM Model/SWMM","L_102last_Flow");
matrix y103Q=api.getResultMatrix("SWMM Model/SWMM","L_103last_Flow");
matrix y104Q=api.getResultMatrix("SWMM Model/SWMM","L_104last_Flow");
matrix y105Q=api.getResultMatrix("SWMM Model/SWMM","L_105last_Flow");
matrix y106Q=api.getResultMatrix("SWMM Model/SWMM","L_106last_Flow");
matrix y107Q=api.getResultMatrix("SWMM Model/SWMM","L_107last_Flow");
matrix y108Q=api.getResultMatrix("SWMM Model/SWMM","L_108last_Flow");
matrix y109Q=api.getResultMatrix("SWMM Model/SWMM","L_109last_Flow");
matrix y110Q=api.getResultMatrix("SWMM Model/SWMM","L_110last_Flow");
matrix y111Q=api.getResultMatrix("SWMM Model/SWMM","L_111last_Flow");
matrix y112Q=api.getResultMatrix("SWMM Model/SWMM","L_112last_Flow");
matrix y113Q=api.getResultMatrix("SWMM Model/SWMM","L_113last_Flow");
matrix y114Q=api.getResultMatrix("SWMM Model/SWMM","L_114last_Flow");
matrix y115Q=api.getResultMatrix("SWMM Model/SWMM","L_115last_Flow");
matrix y116Q=api.getResultMatrix("SWMM Model/SWMM","L_116last_Flow");
matrix y117Q=api.getResultMatrix("SWMM Model/SWMM","L_117last_Flow");
matrix y118Q=api.getResultMatrix("SWMM Model/SWMM","L_118last_Flow");
matrix y119Q=api.getResultMatrix("SWMM Model/SWMM","L_119last_Flow");
matrix y120Q=api.getResultMatrix("SWMM Model/SWMM","L_120last_Flow");
matrix y121Q=api.getResultMatrix("SWMM Model/SWMM","L_121last_Flow");
matrix y122Q=api.getResultMatrix("SWMM Model/SWMM","L_122last_Flow");
matrix y123Q=api.getResultMatrix("SWMM Model/SWMM","L_123last_Flow");
matrix y124Q=api.getResultMatrix("SWMM Model/SWMM","L_124last_Flow");
matrix y125Q=api.getResultMatrix("SWMM Model/SWMM","L_125last_Flow");
matrix y126Q=api.getResultMatrix("SWMM Model/SWMM","L_126last_Flow");
matrix y127Q=api.getResultMatrix("SWMM Model/SWMM","L_127last_Flow");
matrix y128Q=api.getResultMatrix("SWMM Model/SWMM","L_128last_Flow");
matrix y129Q=api.getResultMatrix("SWMM Model/SWMM","L_129last_Flow");
matrix y130Q=api.getResultMatrix("SWMM Model/SWMM","L_130last_Flow");
matrix y131Q=api.getResultMatrix("SWMM Model/SWMM","L_131last_Flow");
matrix y132Q=api.getResultMatrix("SWMM Model/SWMM","L_132last_Flow");
matrix y133Q=api.getResultMatrix("SWMM Model/SWMM","L_133last_Flow");
matrix y134Q=api.getResultMatrix("SWMM Model/SWMM","L_134last_Flow");
matrix y135Q=api.getResultMatrix("SWMM Model/SWMM","L_135last_Flow");
matrix y136Q=api.getResultMatrix("SWMM Model/SWMM","L_136last_Flow");
matrix y137Q=api.getResultMatrix("SWMM Model/SWMM","L_137last_Flow");
matrix y138Q=api.getResultMatrix("SWMM Model/SWMM","L_138last_Flow");
matrix y139Q=api.getResultMatrix("SWMM Model/SWMM","L_139last_Flow");
matrix y140Q=api.getResultMatrix("SWMM Model/SWMM","L_140last_Flow");
matrix y141Q=api.getResultMatrix("SWMM Model/SWMM","L_141last_Flow");
matrix y142Q=api.getResultMatrix("SWMM Model/SWMM","L_142last_Flow");
matrix y143Q=api.getResultMatrix("SWMM Model/SWMM","L_143last_Flow");
matrix y144Q=api.getResultMatrix("SWMM Model/SWMM","L_144last_Flow");
matrix y145Q=api.getResultMatrix("SWMM Model/SWMM","L_145last_Flow");
matrix y146Q=api.getResultMatrix("SWMM Model/SWMM","L_146last_Flow");
matrix y147Q=api.getResultMatrix("SWMM Model/SWMM","L_147last_Flow");
matrix y148Q=api.getResultMatrix("SWMM Model/SWMM","L_148last_Flow");
matrix y149Q=api.getResultMatrix("SWMM Model/SWMM","L_149last_Flow");


// VELOCITY RESULTS:
matrix y1V=api.getResultMatrix("SWMM Model/SWMM","L_1last_Velocity");
matrix y2V=api.getResultMatrix("SWMM Model/SWMM","L_2last_Velocity");
matrix y3V=api.getResultMatrix("SWMM Model/SWMM","L_3last_Velocity");
matrix y4V=api.getResultMatrix("SWMM Model/SWMM","L_4last_Velocity");
matrix y5V=api.getResultMatrix("SWMM Model/SWMM","L_5last_Velocity");
matrix y6V=api.getResultMatrix("SWMM Model/SWMM","L_6last_Velocity");
matrix y7V=api.getResultMatrix("SWMM Model/SWMM","L_7last_Velocity");
matrix y8V=api.getResultMatrix("SWMM Model/SWMM","L_8last_Velocity");
matrix y9V=api.getResultMatrix("SWMM Model/SWMM","L_9last_Velocity");
matrix y10V=api.getResultMatrix("SWMM Model/SWMM","L_10last_Velocity");
matrix y11V=api.getResultMatrix("SWMM Model/SWMM","L_11last_Velocity");
matrix y12V=api.getResultMatrix("SWMM Model/SWMM","L_12last_Velocity");
matrix y13V=api.getResultMatrix("SWMM Model/SWMM","L_13last_Velocity");
matrix y14V=api.getResultMatrix("SWMM Model/SWMM","L_14last_Velocity");
matrix y15V=api.getResultMatrix("SWMM Model/SWMM","L_15last_Velocity");
matrix y16V=api.getResultMatrix("SWMM Model/SWMM","L_16last_Velocity");
matrix y17V=api.getResultMatrix("SWMM Model/SWMM","L_17last_Velocity");
matrix y18V=api.getResultMatrix("SWMM Model/SWMM","L_18last_Velocity");
matrix y19V=api.getResultMatrix("SWMM Model/SWMM","L_19last_Velocity");
matrix y20V=api.getResultMatrix("SWMM Model/SWMM","L_20last_Velocity");
matrix y21V=api.getResultMatrix("SWMM Model/SWMM","L_21last_Velocity");
matrix y22V=api.getResultMatrix("SWMM Model/SWMM","L_22last_Velocity");
matrix y23V=api.getResultMatrix("SWMM Model/SWMM","L_23last_Velocity");
matrix y24V=api.getResultMatrix("SWMM Model/SWMM","L_24last_Velocity");
matrix y25V=api.getResultMatrix("SWMM Model/SWMM","L_25last_Velocity");
matrix y26V=api.getResultMatrix("SWMM Model/SWMM","L_26last_Velocity");
matrix y27V=api.getResultMatrix("SWMM Model/SWMM","L_27last_Velocity");
matrix y28V=api.getResultMatrix("SWMM Model/SWMM","L_28last_Velocity");
matrix y29V=api.getResultMatrix("SWMM Model/SWMM","L_29last_Velocity");
matrix y30V=api.getResultMatrix("SWMM Model/SWMM","L_30last_Velocity");
matrix y31V=api.getResultMatrix("SWMM Model/SWMM","L_31last_Velocity");
matrix y32V=api.getResultMatrix("SWMM Model/SWMM","L_32last_Velocity");
matrix y33V=api.getResultMatrix("SWMM Model/SWMM","L_33last_Velocity");
matrix y34V=api.getResultMatrix("SWMM Model/SWMM","L_34last_Velocity");
matrix y35V=api.getResultMatrix("SWMM Model/SWMM","L_35last_Velocity");
matrix y36V=api.getResultMatrix("SWMM Model/SWMM","L_36last_Velocity");
matrix y37V=api.getResultMatrix("SWMM Model/SWMM","L_37last_Velocity");
matrix y38V=api.getResultMatrix("SWMM Model/SWMM","L_38last_Velocity");
matrix y39V=api.getResultMatrix("SWMM Model/SWMM","L_39last_Velocity");
matrix y40V=api.getResultMatrix("SWMM Model/SWMM","L_40last_Velocity");
matrix y41V=api.getResultMatrix("SWMM Model/SWMM","L_41last_Velocity");
matrix y42V=api.getResultMatrix("SWMM Model/SWMM","L_42last_Velocity");
matrix y43V=api.getResultMatrix("SWMM Model/SWMM","L_43last_Velocity");
matrix y44V=api.getResultMatrix("SWMM Model/SWMM","L_44last_Velocity");
matrix y45V=api.getResultMatrix("SWMM Model/SWMM","L_45last_Velocity");
matrix y46V=api.getResultMatrix("SWMM Model/SWMM","L_46last_Velocity");
matrix y47V=api.getResultMatrix("SWMM Model/SWMM","L_47last_Velocity");
matrix y48V=api.getResultMatrix("SWMM Model/SWMM","L_48last_Velocity");
matrix y49V=api.getResultMatrix("SWMM Model/SWMM","L_49last_Velocity");
matrix y50V=api.getResultMatrix("SWMM Model/SWMM","L_50last_Velocity");
matrix y51V=api.getResultMatrix("SWMM Model/SWMM","L_51last_Velocity");
matrix y52V=api.getResultMatrix("SWMM Model/SWMM","L_52last_Velocity");
matrix y53V=api.getResultMatrix("SWMM Model/SWMM","L_53last_Velocity");
matrix y54V=api.getResultMatrix("SWMM Model/SWMM","L_54last_Velocity");
matrix y55V=api.getResultMatrix("SWMM Model/SWMM","L_55last_Velocity");
matrix y56V=api.getResultMatrix("SWMM Model/SWMM","L_56last_Velocity");
matrix y57V=api.getResultMatrix("SWMM Model/SWMM","L_57last_Velocity");
matrix y58V=api.getResultMatrix("SWMM Model/SWMM","L_58last_Velocity");
matrix y59V=api.getResultMatrix("SWMM Model/SWMM","L_59last_Velocity");
matrix y60V=api.getResultMatrix("SWMM Model/SWMM","L_60last_Velocity");
matrix y61V=api.getResultMatrix("SWMM Model/SWMM","L_61last_Velocity");
matrix y62V=api.getResultMatrix("SWMM Model/SWMM","L_62last_Velocity");
matrix y63V=api.getResultMatrix("SWMM Model/SWMM","L_63last_Velocity");
matrix y64V=api.getResultMatrix("SWMM Model/SWMM","L_64last_Velocity");
matrix y65V=api.getResultMatrix("SWMM Model/SWMM","L_65last_Velocity");
matrix y66V=api.getResultMatrix("SWMM Model/SWMM","L_66last_Velocity");
matrix y67V=api.getResultMatrix("SWMM Model/SWMM","L_67last_Velocity");
matrix y68V=api.getResultMatrix("SWMM Model/SWMM","L_68last_Velocity");
matrix y69V=api.getResultMatrix("SWMM Model/SWMM","L_69last_Velocity");
matrix y70V=api.getResultMatrix("SWMM Model/SWMM","L_70last_Velocity");
matrix y71V=api.getResultMatrix("SWMM Model/SWMM","L_71last_Velocity");
matrix y72V=api.getResultMatrix("SWMM Model/SWMM","L_72last_Velocity");
matrix y73V=api.getResultMatrix("SWMM Model/SWMM","L_73last_Velocity");
matrix y74V=api.getResultMatrix("SWMM Model/SWMM","L_74last_Velocity");
matrix y75V=api.getResultMatrix("SWMM Model/SWMM","L_75last_Velocity");
matrix y76V=api.getResultMatrix("SWMM Model/SWMM","L_76last_Velocity");
matrix y77V=api.getResultMatrix("SWMM Model/SWMM","L_77last_Velocity");
matrix y78V=api.getResultMatrix("SWMM Model/SWMM","L_78last_Velocity");
matrix y79V=api.getResultMatrix("SWMM Model/SWMM","L_79last_Velocity");
matrix y80V=api.getResultMatrix("SWMM Model/SWMM","L_80last_Velocity");
matrix y81V=api.getResultMatrix("SWMM Model/SWMM","L_81last_Velocity");
matrix y82V=api.getResultMatrix("SWMM Model/SWMM","L_82last_Velocity");
matrix y83V=api.getResultMatrix("SWMM Model/SWMM","L_83last_Velocity");
matrix y84V=api.getResultMatrix("SWMM Model/SWMM","L_84last_Velocity");
matrix y85V=api.getResultMatrix("SWMM Model/SWMM","L_85last_Velocity");
matrix y86V=api.getResultMatrix("SWMM Model/SWMM","L_86last_Velocity");
matrix y87V=api.getResultMatrix("SWMM Model/SWMM","L_87last_Velocity");
matrix y88V=api.getResultMatrix("SWMM Model/SWMM","L_88last_Velocity");
matrix y89V=api.getResultMatrix("SWMM Model/SWMM","L_89last_Velocity");
matrix y90V=api.getResultMatrix("SWMM Model/SWMM","L_90last_Velocity");
matrix y91V=api.getResultMatrix("SWMM Model/SWMM","L_91last_Velocity");
matrix y92V=api.getResultMatrix("SWMM Model/SWMM","L_92last_Velocity");
matrix y93V=api.getResultMatrix("SWMM Model/SWMM","L_93last_Velocity");
matrix y94V=api.getResultMatrix("SWMM Model/SWMM","L_94last_Velocity");
matrix y95V=api.getResultMatrix("SWMM Model/SWMM","L_95last_Velocity");
matrix y96V=api.getResultMatrix("SWMM Model/SWMM","L_96last_Velocity");
matrix y97V=api.getResultMatrix("SWMM Model/SWMM","L_97last_Velocity");
matrix y98V=api.getResultMatrix("SWMM Model/SWMM","L_98last_Velocity");
matrix y99V=api.getResultMatrix("SWMM Model/SWMM","L_99last_Velocity");
matrix y100V=api.getResultMatrix("SWMM Model/SWMM","L_100last_Velocity");
matrix y101V=api.getResultMatrix("SWMM Model/SWMM","L_101last_Velocity");
matrix y102V=api.getResultMatrix("SWMM Model/SWMM","L_102last_Velocity");
matrix y103V=api.getResultMatrix("SWMM Model/SWMM","L_103last_Velocity");
matrix y104V=api.getResultMatrix("SWMM Model/SWMM","L_104last_Velocity");
matrix y105V=api.getResultMatrix("SWMM Model/SWMM","L_105last_Velocity");
matrix y106V=api.getResultMatrix("SWMM Model/SWMM","L_106last_Velocity");
matrix y107V=api.getResultMatrix("SWMM Model/SWMM","L_107last_Velocity");
matrix y108V=api.getResultMatrix("SWMM Model/SWMM","L_108last_Velocity");
matrix y109V=api.getResultMatrix("SWMM Model/SWMM","L_109last_Velocity");
matrix y110V=api.getResultMatrix("SWMM Model/SWMM","L_110last_Velocity");
matrix y111V=api.getResultMatrix("SWMM Model/SWMM","L_111last_Velocity");
matrix y112V=api.getResultMatrix("SWMM Model/SWMM","L_112last_Velocity");
matrix y113V=api.getResultMatrix("SWMM Model/SWMM","L_113last_Velocity");
matrix y114V=api.getResultMatrix("SWMM Model/SWMM","L_114last_Velocity");
matrix y115V=api.getResultMatrix("SWMM Model/SWMM","L_115last_Velocity");
matrix y116V=api.getResultMatrix("SWMM Model/SWMM","L_116last_Velocity");
matrix y117V=api.getResultMatrix("SWMM Model/SWMM","L_117last_Velocity");
matrix y118V=api.getResultMatrix("SWMM Model/SWMM","L_118last_Velocity");
matrix y119V=api.getResultMatrix("SWMM Model/SWMM","L_119last_Velocity");
matrix y120V=api.getResultMatrix("SWMM Model/SWMM","L_120last_Velocity");
matrix y121V=api.getResultMatrix("SWMM Model/SWMM","L_121last_Velocity");
matrix y122V=api.getResultMatrix("SWMM Model/SWMM","L_122last_Velocity");
matrix y123V=api.getResultMatrix("SWMM Model/SWMM","L_123last_Velocity");
matrix y124V=api.getResultMatrix("SWMM Model/SWMM","L_124last_Velocity");
matrix y125V=api.getResultMatrix("SWMM Model/SWMM","L_125last_Velocity");
matrix y126V=api.getResultMatrix("SWMM Model/SWMM","L_126last_Velocity");
matrix y127V=api.getResultMatrix("SWMM Model/SWMM","L_127last_Velocity");
matrix y128V=api.getResultMatrix("SWMM Model/SWMM","L_128last_Velocity");
matrix y129V=api.getResultMatrix("SWMM Model/SWMM","L_129last_Velocity");
matrix y130V=api.getResultMatrix("SWMM Model/SWMM","L_130last_Velocity");
matrix y131V=api.getResultMatrix("SWMM Model/SWMM","L_131last_Velocity");
matrix y132V=api.getResultMatrix("SWMM Model/SWMM","L_132last_Velocity");
matrix y133V=api.getResultMatrix("SWMM Model/SWMM","L_133last_Velocity");
matrix y134V=api.getResultMatrix("SWMM Model/SWMM","L_134last_Velocity");
matrix y135V=api.getResultMatrix("SWMM Model/SWMM","L_135last_Velocity");
matrix y136V=api.getResultMatrix("SWMM Model/SWMM","L_136last_Velocity");
matrix y137V=api.getResultMatrix("SWMM Model/SWMM","L_137last_Velocity");
matrix y138V=api.getResultMatrix("SWMM Model/SWMM","L_138last_Velocity");
matrix y139V=api.getResultMatrix("SWMM Model/SWMM","L_139last_Velocity");
matrix y140V=api.getResultMatrix("SWMM Model/SWMM","L_140last_Velocity");
matrix y141V=api.getResultMatrix("SWMM Model/SWMM","L_141last_Velocity");
matrix y142V=api.getResultMatrix("SWMM Model/SWMM","L_142last_Velocity");
matrix y143V=api.getResultMatrix("SWMM Model/SWMM","L_143last_Velocity");
matrix y144V=api.getResultMatrix("SWMM Model/SWMM","L_144last_Velocity");
matrix y145V=api.getResultMatrix("SWMM Model/SWMM","L_145last_Velocity");
matrix y146V=api.getResultMatrix("SWMM Model/SWMM","L_146last_Velocity");
matrix y147V=api.getResultMatrix("SWMM Model/SWMM","L_147last_Velocity");
matrix y148V=api.getResultMatrix("SWMM Model/SWMM","L_148last_Velocity");
matrix y149V=api.getResultMatrix("SWMM Model/SWMM","L_149last_Velocity");

// WATER DEPTH RESULTS:
matrix y1D=api.getResultMatrix("SWMM Model/SWMM","L_1last_Depth");
matrix y2D=api.getResultMatrix("SWMM Model/SWMM","L_2last_Depth");
matrix y3D=api.getResultMatrix("SWMM Model/SWMM","L_3last_Depth");
matrix y4D=api.getResultMatrix("SWMM Model/SWMM","L_4last_Depth");
matrix y5D=api.getResultMatrix("SWMM Model/SWMM","L_5last_Depth");
matrix y6D=api.getResultMatrix("SWMM Model/SWMM","L_6last_Depth");
matrix y7D=api.getResultMatrix("SWMM Model/SWMM","L_7last_Depth");
matrix y8D=api.getResultMatrix("SWMM Model/SWMM","L_8last_Depth");
matrix y9D=api.getResultMatrix("SWMM Model/SWMM","L_9last_Depth");
matrix y10D=api.getResultMatrix("SWMM Model/SWMM","L_10last_Depth");
matrix y11D=api.getResultMatrix("SWMM Model/SWMM","L_11last_Depth");
matrix y12D=api.getResultMatrix("SWMM Model/SWMM","L_12last_Depth");
matrix y13D=api.getResultMatrix("SWMM Model/SWMM","L_13last_Depth");
matrix y14D=api.getResultMatrix("SWMM Model/SWMM","L_14last_Depth");
matrix y15D=api.getResultMatrix("SWMM Model/SWMM","L_15last_Depth");
matrix y16D=api.getResultMatrix("SWMM Model/SWMM","L_16last_Depth");
matrix y17D=api.getResultMatrix("SWMM Model/SWMM","L_17last_Depth");
matrix y18D=api.getResultMatrix("SWMM Model/SWMM","L_18last_Depth");
matrix y19D=api.getResultMatrix("SWMM Model/SWMM","L_19last_Depth");
matrix y20D=api.getResultMatrix("SWMM Model/SWMM","L_20last_Depth");
matrix y21D=api.getResultMatrix("SWMM Model/SWMM","L_21last_Depth");
matrix y22D=api.getResultMatrix("SWMM Model/SWMM","L_22last_Depth");
matrix y23D=api.getResultMatrix("SWMM Model/SWMM","L_23last_Depth");
matrix y24D=api.getResultMatrix("SWMM Model/SWMM","L_24last_Depth");
matrix y25D=api.getResultMatrix("SWMM Model/SWMM","L_25last_Depth");
matrix y26D=api.getResultMatrix("SWMM Model/SWMM","L_26last_Depth");
matrix y27D=api.getResultMatrix("SWMM Model/SWMM","L_27last_Depth");
matrix y28D=api.getResultMatrix("SWMM Model/SWMM","L_28last_Depth");
matrix y29D=api.getResultMatrix("SWMM Model/SWMM","L_29last_Depth");
matrix y30D=api.getResultMatrix("SWMM Model/SWMM","L_30last_Depth");
matrix y31D=api.getResultMatrix("SWMM Model/SWMM","L_31last_Depth");
matrix y32D=api.getResultMatrix("SWMM Model/SWMM","L_32last_Depth");
matrix y33D=api.getResultMatrix("SWMM Model/SWMM","L_33last_Depth");
matrix y34D=api.getResultMatrix("SWMM Model/SWMM","L_34last_Depth");
matrix y35D=api.getResultMatrix("SWMM Model/SWMM","L_35last_Depth");
matrix y36D=api.getResultMatrix("SWMM Model/SWMM","L_36last_Depth");
matrix y37D=api.getResultMatrix("SWMM Model/SWMM","L_37last_Depth");
matrix y38D=api.getResultMatrix("SWMM Model/SWMM","L_38last_Depth");
matrix y39D=api.getResultMatrix("SWMM Model/SWMM","L_39last_Depth");
matrix y40D=api.getResultMatrix("SWMM Model/SWMM","L_40last_Depth");
matrix y41D=api.getResultMatrix("SWMM Model/SWMM","L_41last_Depth");
matrix y42D=api.getResultMatrix("SWMM Model/SWMM","L_42last_Depth");
matrix y43D=api.getResultMatrix("SWMM Model/SWMM","L_43last_Depth");
matrix y44D=api.getResultMatrix("SWMM Model/SWMM","L_44last_Depth");
matrix y45D=api.getResultMatrix("SWMM Model/SWMM","L_45last_Depth");
matrix y46D=api.getResultMatrix("SWMM Model/SWMM","L_46last_Depth");
matrix y47D=api.getResultMatrix("SWMM Model/SWMM","L_47last_Depth");
matrix y48D=api.getResultMatrix("SWMM Model/SWMM","L_48last_Depth");
matrix y49D=api.getResultMatrix("SWMM Model/SWMM","L_49last_Depth");
matrix y50D=api.getResultMatrix("SWMM Model/SWMM","L_50last_Depth");
matrix y51D=api.getResultMatrix("SWMM Model/SWMM","L_51last_Depth");
matrix y52D=api.getResultMatrix("SWMM Model/SWMM","L_52last_Depth");
matrix y53D=api.getResultMatrix("SWMM Model/SWMM","L_53last_Depth");
matrix y54D=api.getResultMatrix("SWMM Model/SWMM","L_54last_Depth");
matrix y55D=api.getResultMatrix("SWMM Model/SWMM","L_55last_Depth");
matrix y56D=api.getResultMatrix("SWMM Model/SWMM","L_56last_Depth");
matrix y57D=api.getResultMatrix("SWMM Model/SWMM","L_57last_Depth");
matrix y58D=api.getResultMatrix("SWMM Model/SWMM","L_58last_Depth");
matrix y59D=api.getResultMatrix("SWMM Model/SWMM","L_59last_Depth");
matrix y60D=api.getResultMatrix("SWMM Model/SWMM","L_60last_Depth");
matrix y61D=api.getResultMatrix("SWMM Model/SWMM","L_61last_Depth");
matrix y62D=api.getResultMatrix("SWMM Model/SWMM","L_62last_Depth");
matrix y63D=api.getResultMatrix("SWMM Model/SWMM","L_63last_Depth");
matrix y64D=api.getResultMatrix("SWMM Model/SWMM","L_64last_Depth");
matrix y65D=api.getResultMatrix("SWMM Model/SWMM","L_65last_Depth");
matrix y66D=api.getResultMatrix("SWMM Model/SWMM","L_66last_Depth");
matrix y67D=api.getResultMatrix("SWMM Model/SWMM","L_67last_Depth");
matrix y68D=api.getResultMatrix("SWMM Model/SWMM","L_68last_Depth");
matrix y69D=api.getResultMatrix("SWMM Model/SWMM","L_69last_Depth");
matrix y70D=api.getResultMatrix("SWMM Model/SWMM","L_70last_Depth");
matrix y71D=api.getResultMatrix("SWMM Model/SWMM","L_71last_Depth");
matrix y72D=api.getResultMatrix("SWMM Model/SWMM","L_72last_Depth");
matrix y73D=api.getResultMatrix("SWMM Model/SWMM","L_73last_Depth");
matrix y74D=api.getResultMatrix("SWMM Model/SWMM","L_74last_Depth");
matrix y75D=api.getResultMatrix("SWMM Model/SWMM","L_75last_Depth");
matrix y76D=api.getResultMatrix("SWMM Model/SWMM","L_76last_Depth");
matrix y77D=api.getResultMatrix("SWMM Model/SWMM","L_77last_Depth");
matrix y78D=api.getResultMatrix("SWMM Model/SWMM","L_78last_Depth");
matrix y79D=api.getResultMatrix("SWMM Model/SWMM","L_79last_Depth");
matrix y80D=api.getResultMatrix("SWMM Model/SWMM","L_80last_Depth");
matrix y81D=api.getResultMatrix("SWMM Model/SWMM","L_81last_Depth");
matrix y82D=api.getResultMatrix("SWMM Model/SWMM","L_82last_Depth");
matrix y83D=api.getResultMatrix("SWMM Model/SWMM","L_83last_Depth");
matrix y84D=api.getResultMatrix("SWMM Model/SWMM","L_84last_Depth");
matrix y85D=api.getResultMatrix("SWMM Model/SWMM","L_85last_Depth");
matrix y86D=api.getResultMatrix("SWMM Model/SWMM","L_86last_Depth");
matrix y87D=api.getResultMatrix("SWMM Model/SWMM","L_87last_Depth");
matrix y88D=api.getResultMatrix("SWMM Model/SWMM","L_88last_Depth");
matrix y89D=api.getResultMatrix("SWMM Model/SWMM","L_89last_Depth");
matrix y90D=api.getResultMatrix("SWMM Model/SWMM","L_90last_Depth");
matrix y91D=api.getResultMatrix("SWMM Model/SWMM","L_91last_Depth");
matrix y92D=api.getResultMatrix("SWMM Model/SWMM","L_92last_Depth");
matrix y93D=api.getResultMatrix("SWMM Model/SWMM","L_93last_Depth");
matrix y94D=api.getResultMatrix("SWMM Model/SWMM","L_94last_Depth");
matrix y95D=api.getResultMatrix("SWMM Model/SWMM","L_95last_Depth");
matrix y96D=api.getResultMatrix("SWMM Model/SWMM","L_96last_Depth");
matrix y97D=api.getResultMatrix("SWMM Model/SWMM","L_97last_Depth");
matrix y98D=api.getResultMatrix("SWMM Model/SWMM","L_98last_Depth");
matrix y99D=api.getResultMatrix("SWMM Model/SWMM","L_99last_Depth");
matrix y100D=api.getResultMatrix("SWMM Model/SWMM","L_100last_Depth");
matrix y101D=api.getResultMatrix("SWMM Model/SWMM","L_101last_Depth");
matrix y102D=api.getResultMatrix("SWMM Model/SWMM","L_102last_Depth");
matrix y103D=api.getResultMatrix("SWMM Model/SWMM","L_103last_Depth");
matrix y104D=api.getResultMatrix("SWMM Model/SWMM","L_104last_Depth");
matrix y105D=api.getResultMatrix("SWMM Model/SWMM","L_105last_Depth");
matrix y106D=api.getResultMatrix("SWMM Model/SWMM","L_106last_Depth");
matrix y107D=api.getResultMatrix("SWMM Model/SWMM","L_107last_Depth");
matrix y108D=api.getResultMatrix("SWMM Model/SWMM","L_108last_Depth");
matrix y109D=api.getResultMatrix("SWMM Model/SWMM","L_109last_Depth");
matrix y110D=api.getResultMatrix("SWMM Model/SWMM","L_110last_Depth");
matrix y111D=api.getResultMatrix("SWMM Model/SWMM","L_111last_Depth");
matrix y112D=api.getResultMatrix("SWMM Model/SWMM","L_112last_Depth");
matrix y113D=api.getResultMatrix("SWMM Model/SWMM","L_113last_Depth");
matrix y114D=api.getResultMatrix("SWMM Model/SWMM","L_114last_Depth");
matrix y115D=api.getResultMatrix("SWMM Model/SWMM","L_115last_Depth");
matrix y116D=api.getResultMatrix("SWMM Model/SWMM","L_116last_Depth");
matrix y117D=api.getResultMatrix("SWMM Model/SWMM","L_117last_Depth");
matrix y118D=api.getResultMatrix("SWMM Model/SWMM","L_118last_Depth");
matrix y119D=api.getResultMatrix("SWMM Model/SWMM","L_119last_Depth");
matrix y120D=api.getResultMatrix("SWMM Model/SWMM","L_120last_Depth");
matrix y121D=api.getResultMatrix("SWMM Model/SWMM","L_121last_Depth");
matrix y122D=api.getResultMatrix("SWMM Model/SWMM","L_122last_Depth");
matrix y123D=api.getResultMatrix("SWMM Model/SWMM","L_123last_Depth");
matrix y124D=api.getResultMatrix("SWMM Model/SWMM","L_124last_Depth");
matrix y125D=api.getResultMatrix("SWMM Model/SWMM","L_125last_Depth");
matrix y126D=api.getResultMatrix("SWMM Model/SWMM","L_126last_Depth");
matrix y127D=api.getResultMatrix("SWMM Model/SWMM","L_127last_Depth");
matrix y128D=api.getResultMatrix("SWMM Model/SWMM","L_128last_Depth");
matrix y129D=api.getResultMatrix("SWMM Model/SWMM","L_129last_Depth");
matrix y130D=api.getResultMatrix("SWMM Model/SWMM","L_130last_Depth");
matrix y131D=api.getResultMatrix("SWMM Model/SWMM","L_131last_Depth");
matrix y132D=api.getResultMatrix("SWMM Model/SWMM","L_132last_Depth");
matrix y133D=api.getResultMatrix("SWMM Model/SWMM","L_133last_Depth");
matrix y134D=api.getResultMatrix("SWMM Model/SWMM","L_134last_Depth");
matrix y135D=api.getResultMatrix("SWMM Model/SWMM","L_135last_Depth");
matrix y136D=api.getResultMatrix("SWMM Model/SWMM","L_136last_Depth");
matrix y137D=api.getResultMatrix("SWMM Model/SWMM","L_137last_Depth");
matrix y138D=api.getResultMatrix("SWMM Model/SWMM","L_138last_Depth");
matrix y139D=api.getResultMatrix("SWMM Model/SWMM","L_139last_Depth");
matrix y140D=api.getResultMatrix("SWMM Model/SWMM","L_140last_Depth");
matrix y141D=api.getResultMatrix("SWMM Model/SWMM","L_141last_Depth");
matrix y142D=api.getResultMatrix("SWMM Model/SWMM","L_142last_Depth");
matrix y143D=api.getResultMatrix("SWMM Model/SWMM","L_143last_Depth");
matrix y144D=api.getResultMatrix("SWMM Model/SWMM","L_144last_Depth");
matrix y145D=api.getResultMatrix("SWMM Model/SWMM","L_145last_Depth");
matrix y146D=api.getResultMatrix("SWMM Model/SWMM","L_146last_Depth");
matrix y147D=api.getResultMatrix("SWMM Model/SWMM","L_147last_Depth");
matrix y148D=api.getResultMatrix("SWMM Model/SWMM","L_148last_Depth");
matrix y149D=api.getResultMatrix("SWMM Model/SWMM","L_149last_Depth");


//save flow in a text file
using (System.IO.StreamWriter file = new System.IO.StreamWriter("SWMMFlowRS.txt")) {
  for (int i=0; i<y1Q.mrow; i++) {
         //the file has 2 columns first the coresponding time, second results from the first column in y
         file.WriteLine(aConv.double2string(y1Q[i,0])  + ", " +aConv.double2string(y1Q[i,1])  + ", " + aConv.double2string(y2Q[i,1])  + ", " + aConv.double2string(y3Q[i,1])  + ", " + aConv.double2string(y4Q[i,1])  + ", " + aConv.double2string(y5Q[i,1])  + ", " + aConv.double2string(y6Q[i,1])  + ", " + aConv.double2string(y7Q[i,1])  + ", " + aConv.double2string(y8Q[i,1])  + ", " + aConv.double2string(y9Q[i,1])  + ", " + aConv.double2string(y10Q[i,1])  + ", " + aConv.double2string(y11Q[i,1])  + ", " + aConv.double2string(y12Q[i,1])  + ", " + aConv.double2string(y13Q[i,1])  + ", " + aConv.double2string(y14Q[i,1])  + ", " + aConv.double2string(y15Q[i,1])  + ", " + aConv.double2string(y16Q[i,1])  + ", " + aConv.double2string(y17Q[i,1])  + ", " + aConv.double2string(y18Q[i,1])  + ", " + aConv.double2string(y19Q[i,1])  + ", " + aConv.double2string(y20Q[i,1])  + ", " + aConv.double2string(y21Q[i,1])  + ", " + aConv.double2string(y22Q[i,1])  + ", " + aConv.double2string(y23Q[i,1])  + ", " + aConv.double2string(y24Q[i,1])  + ", " + aConv.double2string(y25Q[i,1])  + ", " + aConv.double2string(y26Q[i,1])  + ", " + aConv.double2string(y27Q[i,1])  + ", " + aConv.double2string(y28Q[i,1])  + ", " + aConv.double2string(y29Q[i,1])  + ", " + aConv.double2string(y30Q[i,1])  + ", " + aConv.double2string(y31Q[i,1])  + ", " + aConv.double2string(y32Q[i,1])  + ", " + aConv.double2string(y33Q[i,1])  + ", " + aConv.double2string(y34Q[i,1])  + ", " + aConv.double2string(y35Q[i,1])  + ", " + aConv.double2string(y36Q[i,1])  + ", " + aConv.double2string(y37Q[i,1])  + ", " + aConv.double2string(y38Q[i,1])  + ", " + aConv.double2string(y39Q[i,1])  + ", " + aConv.double2string(y40Q[i,1])  + ", " + aConv.double2string(y41Q[i,1])  + ", " + aConv.double2string(y42Q[i,1])  + ", " + aConv.double2string(y43Q[i,1])  + ", " + aConv.double2string(y44Q[i,1])  + ", " + aConv.double2string(y45Q[i,1])  + ", " + aConv.double2string(y46Q[i,1])  + ", " + aConv.double2string(y47Q[i,1])  + ", " + aConv.double2string(y48Q[i,1])  + ", " + aConv.double2string(y49Q[i,1])  + ", " + aConv.double2string(y50Q[i,1])  + ", " + aConv.double2string(y51Q[i,1])  + ", " + aConv.double2string(y52Q[i,1])  + ", " + aConv.double2string(y53Q[i,1])  + ", " + aConv.double2string(y54Q[i,1])  + ", " + aConv.double2string(y55Q[i,1])  + ", " + aConv.double2string(y56Q[i,1])  + ", " + aConv.double2string(y57Q[i,1])  + ", " + aConv.double2string(y58Q[i,1])  + ", " + aConv.double2string(y59Q[i,1])  + ", " + aConv.double2string(y60Q[i,1])  + ", " + aConv.double2string(y61Q[i,1])  + ", " + aConv.double2string(y62Q[i,1])  + ", " + aConv.double2string(y63Q[i,1])  + ", " + aConv.double2string(y64Q[i,1])  + ", " + aConv.double2string(y65Q[i,1])  + ", " + aConv.double2string(y66Q[i,1])  + ", " + aConv.double2string(y67Q[i,1])  + ", " + aConv.double2string(y68Q[i,1])  + ", " + aConv.double2string(y69Q[i,1])  + ", " + aConv.double2string(y70Q[i,1])  + ", " + aConv.double2string(y71Q[i,1])  + ", " + aConv.double2string(y72Q[i,1])  + ", " + aConv.double2string(y73Q[i,1])  + ", " + aConv.double2string(y74Q[i,1])  + ", " + aConv.double2string(y75Q[i,1])  + ", " + aConv.double2string(y76Q[i,1])  + ", " + aConv.double2string(y77Q[i,1])  + ", " + aConv.double2string(y78Q[i,1])  + ", " + aConv.double2string(y79Q[i,1])  + ", " + aConv.double2string(y80Q[i,1])  + ", " + aConv.double2string(y81Q[i,1])  + ", " + aConv.double2string(y82Q[i,1])  + ", " + aConv.double2string(y83Q[i,1])  + ", " + aConv.double2string(y84Q[i,1])  + ", " + aConv.double2string(y85Q[i,1])  + ", " + aConv.double2string(y86Q[i,1])  + ", " + aConv.double2string(y87Q[i,1])  + ", " + aConv.double2string(y88Q[i,1])  + ", " + aConv.double2string(y89Q[i,1])  + ", " + aConv.double2string(y90Q[i,1])  + ", " + aConv.double2string(y91Q[i,1])  + ", " + aConv.double2string(y92Q[i,1])  + ", " + aConv.double2string(y93Q[i,1])  + ", " + aConv.double2string(y94Q[i,1])  + ", " + aConv.double2string(y95Q[i,1])  + ", " + aConv.double2string(y96Q[i,1])  + ", " + aConv.double2string(y97Q[i,1])  + ", " + aConv.double2string(y98Q[i,1])  + ", " + aConv.double2string(y99Q[i,1])  + ", " + aConv.double2string(y100Q[i,1])  + ", " + aConv.double2string(y101Q[i,1])  + ", " + aConv.double2string(y102Q[i,1])  + ", " + aConv.double2string(y103Q[i,1])  + ", " + aConv.double2string(y104Q[i,1])  + ", " + aConv.double2string(y105Q[i,1])  + ", " + aConv.double2string(y106Q[i,1])  + ", " + aConv.double2string(y107Q[i,1])  + ", " + aConv.double2string(y108Q[i,1])  + ", " + aConv.double2string(y109Q[i,1])  + ", " + aConv.double2string(y110Q[i,1])  + ", " + aConv.double2string(y111Q[i,1])  + ", " + aConv.double2string(y112Q[i,1])  + ", " + aConv.double2string(y113Q[i,1])  + ", " + aConv.double2string(y114Q[i,1])  + ", " + aConv.double2string(y115Q[i,1])  + ", " + aConv.double2string(y116Q[i,1])  + ", " + aConv.double2string(y117Q[i,1])  + ", " + aConv.double2string(y118Q[i,1])  + ", " + aConv.double2string(y119Q[i,1])  + ", " + aConv.double2string(y120Q[i,1])  + ", " + aConv.double2string(y121Q[i,1])  + ", " + aConv.double2string(y122Q[i,1])  + ", " + aConv.double2string(y123Q[i,1])  + ", " + aConv.double2string(y124Q[i,1])  + ", " + aConv.double2string(y125Q[i,1])  + ", " + aConv.double2string(y126Q[i,1])  + ", " + aConv.double2string(y127Q[i,1])  + ", " + aConv.double2string(y128Q[i,1])  + ", " + aConv.double2string(y129Q[i,1])  + ", " + aConv.double2string(y130Q[i,1])  + ", " + aConv.double2string(y131Q[i,1])  + ", " + aConv.double2string(y132Q[i,1])  + ", " + aConv.double2string(y133Q[i,1])  + ", " + aConv.double2string(y134Q[i,1])  + ", " + aConv.double2string(y135Q[i,1])  + ", " + aConv.double2string(y136Q[i,1])  + ", " + aConv.double2string(y137Q[i,1])  + ", " + aConv.double2string(y138Q[i,1])  + ", " + aConv.double2string(y139Q[i,1])  + ", " + aConv.double2string(y140Q[i,1])  + ", " + aConv.double2string(y141Q[i,1])  + ", " + aConv.double2string(y142Q[i,1])  + ", " + aConv.double2string(y143Q[i,1])  + ", " + aConv.double2string(y144Q[i,1])  + ", " + aConv.double2string(y145Q[i,1])  + ", " + aConv.double2string(y146Q[i,1])  + ", " + aConv.double2string(y147Q[i,1])  + ", " + aConv.double2string(y148Q[i,1])  + ", " + aConv.double2string(y149Q[i,1]));
  }
}

//save velocity in a text file
using (System.IO.StreamWriter file = new System.IO.StreamWriter("SWMMVelocityRS.txt")) {
  for (int i=0; i<y1Q.mrow; i++) {
         //the file has 2 columns first the coresponding time, second results from the first column in y
         file.WriteLine(aConv.double2string(y1V[i,0])  + ", " +aConv.double2string(y1V[i,1])  + ", " + aConv.double2string(y2V[i,1])  + ", " + aConv.double2string(y3V[i,1])  + ", " + aConv.double2string(y4V[i,1])  + ", " + aConv.double2string(y5V[i,1])  + ", " + aConv.double2string(y6V[i,1])  + ", " + aConv.double2string(y7V[i,1])  + ", " + aConv.double2string(y8V[i,1])  + ", " + aConv.double2string(y9V[i,1])  + ", " + aConv.double2string(y10V[i,1])  + ", " + aConv.double2string(y11V[i,1])  + ", " + aConv.double2string(y12V[i,1])  + ", " + aConv.double2string(y13V[i,1])  + ", " + aConv.double2string(y14V[i,1])  + ", " + aConv.double2string(y15V[i,1])  + ", " + aConv.double2string(y16V[i,1])  + ", " + aConv.double2string(y17V[i,1])  + ", " + aConv.double2string(y18V[i,1])  + ", " + aConv.double2string(y19V[i,1])  + ", " + aConv.double2string(y20V[i,1])  + ", " + aConv.double2string(y21V[i,1])  + ", " + aConv.double2string(y22V[i,1])  + ", " + aConv.double2string(y23V[i,1])  + ", " + aConv.double2string(y24V[i,1])  + ", " + aConv.double2string(y25V[i,1])  + ", " + aConv.double2string(y26V[i,1])  + ", " + aConv.double2string(y27V[i,1])  + ", " + aConv.double2string(y28V[i,1])  + ", " + aConv.double2string(y29V[i,1])  + ", " + aConv.double2string(y30V[i,1])  + ", " + aConv.double2string(y31V[i,1])  + ", " + aConv.double2string(y32V[i,1])  + ", " + aConv.double2string(y33V[i,1])  + ", " + aConv.double2string(y34V[i,1])  + ", " + aConv.double2string(y35V[i,1])  + ", " + aConv.double2string(y36V[i,1])  + ", " + aConv.double2string(y37V[i,1])  + ", " + aConv.double2string(y38V[i,1])  + ", " + aConv.double2string(y39V[i,1])  + ", " + aConv.double2string(y40V[i,1])  + ", " + aConv.double2string(y41V[i,1])  + ", " + aConv.double2string(y42V[i,1])  + ", " + aConv.double2string(y43V[i,1])  + ", " + aConv.double2string(y44V[i,1])  + ", " + aConv.double2string(y45V[i,1])  + ", " + aConv.double2string(y46V[i,1])  + ", " + aConv.double2string(y47V[i,1])  + ", " + aConv.double2string(y48V[i,1])  + ", " + aConv.double2string(y49V[i,1])  + ", " + aConv.double2string(y50V[i,1])  + ", " + aConv.double2string(y51V[i,1])  + ", " + aConv.double2string(y52V[i,1])  + ", " + aConv.double2string(y53V[i,1])  + ", " + aConv.double2string(y54V[i,1])  + ", " + aConv.double2string(y55V[i,1])  + ", " + aConv.double2string(y56V[i,1])  + ", " + aConv.double2string(y57V[i,1])  + ", " + aConv.double2string(y58V[i,1])  + ", " + aConv.double2string(y59V[i,1])  + ", " + aConv.double2string(y60V[i,1])  + ", " + aConv.double2string(y61V[i,1])  + ", " + aConv.double2string(y62V[i,1])  + ", " + aConv.double2string(y63V[i,1])  + ", " + aConv.double2string(y64V[i,1])  + ", " + aConv.double2string(y65V[i,1])  + ", " + aConv.double2string(y66V[i,1])  + ", " + aConv.double2string(y67V[i,1])  + ", " + aConv.double2string(y68V[i,1])  + ", " + aConv.double2string(y69V[i,1])  + ", " + aConv.double2string(y70V[i,1])  + ", " + aConv.double2string(y71V[i,1])  + ", " + aConv.double2string(y72V[i,1])  + ", " + aConv.double2string(y73V[i,1])  + ", " + aConv.double2string(y74V[i,1])  + ", " + aConv.double2string(y75V[i,1])  + ", " + aConv.double2string(y76V[i,1])  + ", " + aConv.double2string(y77V[i,1])  + ", " + aConv.double2string(y78V[i,1])  + ", " + aConv.double2string(y79V[i,1])  + ", " + aConv.double2string(y80V[i,1])  + ", " + aConv.double2string(y81V[i,1])  + ", " + aConv.double2string(y82V[i,1])  + ", " + aConv.double2string(y83V[i,1])  + ", " + aConv.double2string(y84V[i,1])  + ", " + aConv.double2string(y85V[i,1])  + ", " + aConv.double2string(y86V[i,1])  + ", " + aConv.double2string(y87V[i,1])  + ", " + aConv.double2string(y88V[i,1])  + ", " + aConv.double2string(y89V[i,1])  + ", " + aConv.double2string(y90V[i,1])  + ", " + aConv.double2string(y91V[i,1])  + ", " + aConv.double2string(y92V[i,1])  + ", " + aConv.double2string(y93V[i,1])  + ", " + aConv.double2string(y94V[i,1])  + ", " + aConv.double2string(y95V[i,1])  + ", " + aConv.double2string(y96V[i,1])  + ", " + aConv.double2string(y97V[i,1])  + ", " + aConv.double2string(y98V[i,1])  + ", " + aConv.double2string(y99V[i,1])  + ", " + aConv.double2string(y100V[i,1])  + ", " + aConv.double2string(y101V[i,1])  + ", " + aConv.double2string(y102V[i,1])  + ", " + aConv.double2string(y103V[i,1])  + ", " + aConv.double2string(y104V[i,1])  + ", " + aConv.double2string(y105V[i,1])  + ", " + aConv.double2string(y106V[i,1])  + ", " + aConv.double2string(y107V[i,1])  + ", " + aConv.double2string(y108V[i,1])  + ", " + aConv.double2string(y109V[i,1])  + ", " + aConv.double2string(y110V[i,1])  + ", " + aConv.double2string(y111V[i,1])  + ", " + aConv.double2string(y112V[i,1])  + ", " + aConv.double2string(y113V[i,1])  + ", " + aConv.double2string(y114V[i,1])  + ", " + aConv.double2string(y115V[i,1])  + ", " + aConv.double2string(y116V[i,1])  + ", " + aConv.double2string(y117V[i,1])  + ", " + aConv.double2string(y118V[i,1])  + ", " + aConv.double2string(y119V[i,1])  + ", " + aConv.double2string(y120V[i,1])  + ", " + aConv.double2string(y121V[i,1])  + ", " + aConv.double2string(y122V[i,1])  + ", " + aConv.double2string(y123V[i,1])  + ", " + aConv.double2string(y124V[i,1])  + ", " + aConv.double2string(y125V[i,1])  + ", " + aConv.double2string(y126V[i,1])  + ", " + aConv.double2string(y127V[i,1])  + ", " + aConv.double2string(y128V[i,1])  + ", " + aConv.double2string(y129V[i,1])  + ", " + aConv.double2string(y130V[i,1])  + ", " + aConv.double2string(y131V[i,1])  + ", " + aConv.double2string(y132V[i,1])  + ", " + aConv.double2string(y133V[i,1])  + ", " + aConv.double2string(y134V[i,1])  + ", " + aConv.double2string(y135V[i,1])  + ", " + aConv.double2string(y136V[i,1])  + ", " + aConv.double2string(y137V[i,1])  + ", " + aConv.double2string(y138V[i,1])  + ", " + aConv.double2string(y139V[i,1])  + ", " + aConv.double2string(y140V[i,1])  + ", " + aConv.double2string(y141V[i,1])  + ", " + aConv.double2string(y142V[i,1])  + ", " + aConv.double2string(y143V[i,1])  + ", " + aConv.double2string(y144V[i,1])  + ", " + aConv.double2string(y145V[i,1])  + ", " + aConv.double2string(y146V[i,1])  + ", " + aConv.double2string(y147V[i,1])  + ", " + aConv.double2string(y148V[i,1])  + ", " + aConv.double2string(y149V[i,1]));
  }
}


//save water depth in a text file
using (System.IO.StreamWriter file = new System.IO.StreamWriter("SWMMDepthRS.txt")) {
  for (int i=0; i<y1Q.mrow; i++) {
         //the file has 2 columns first the coresponding time, second results from the first column in y
         file.WriteLine(aConv.double2string(y1D[i,0])  + ", " +aConv.double2string(y1D[i,1])  + ", " + aConv.double2string(y2D[i,1])  + ", " + aConv.double2string(y3D[i,1])  + ", " + aConv.double2string(y4D[i,1])  + ", " + aConv.double2string(y5D[i,1])  + ", " + aConv.double2string(y6D[i,1])  + ", " + aConv.double2string(y7D[i,1])  + ", " + aConv.double2string(y8D[i,1])  + ", " + aConv.double2string(y9D[i,1])  + ", " + aConv.double2string(y10D[i,1])  + ", " + aConv.double2string(y11D[i,1])  + ", " + aConv.double2string(y12D[i,1])  + ", " + aConv.double2string(y13D[i,1])  + ", " + aConv.double2string(y14D[i,1])  + ", " + aConv.double2string(y15D[i,1])  + ", " + aConv.double2string(y16D[i,1])  + ", " + aConv.double2string(y17D[i,1])  + ", " + aConv.double2string(y18D[i,1])  + ", " + aConv.double2string(y19D[i,1])  + ", " + aConv.double2string(y20D[i,1])  + ", " + aConv.double2string(y21D[i,1])  + ", " + aConv.double2string(y22D[i,1])  + ", " + aConv.double2string(y23D[i,1])  + ", " + aConv.double2string(y24D[i,1])  + ", " + aConv.double2string(y25D[i,1])  + ", " + aConv.double2string(y26D[i,1])  + ", " + aConv.double2string(y27D[i,1])  + ", " + aConv.double2string(y28D[i,1])  + ", " + aConv.double2string(y29D[i,1])  + ", " + aConv.double2string(y30D[i,1])  + ", " + aConv.double2string(y31D[i,1])  + ", " + aConv.double2string(y32D[i,1])  + ", " + aConv.double2string(y33D[i,1])  + ", " + aConv.double2string(y34D[i,1])  + ", " + aConv.double2string(y35D[i,1])  + ", " + aConv.double2string(y36D[i,1])  + ", " + aConv.double2string(y37D[i,1])  + ", " + aConv.double2string(y38D[i,1])  + ", " + aConv.double2string(y39D[i,1])  + ", " + aConv.double2string(y40D[i,1])  + ", " + aConv.double2string(y41D[i,1])  + ", " + aConv.double2string(y42D[i,1])  + ", " + aConv.double2string(y43D[i,1])  + ", " + aConv.double2string(y44D[i,1])  + ", " + aConv.double2string(y45D[i,1])  + ", " + aConv.double2string(y46D[i,1])  + ", " + aConv.double2string(y47D[i,1])  + ", " + aConv.double2string(y48D[i,1])  + ", " + aConv.double2string(y49D[i,1])  + ", " + aConv.double2string(y50D[i,1])  + ", " + aConv.double2string(y51D[i,1])  + ", " + aConv.double2string(y52D[i,1])  + ", " + aConv.double2string(y53D[i,1])  + ", " + aConv.double2string(y54D[i,1])  + ", " + aConv.double2string(y55D[i,1])  + ", " + aConv.double2string(y56D[i,1])  + ", " + aConv.double2string(y57D[i,1])  + ", " + aConv.double2string(y58D[i,1])  + ", " + aConv.double2string(y59D[i,1])  + ", " + aConv.double2string(y60D[i,1])  + ", " + aConv.double2string(y61D[i,1])  + ", " + aConv.double2string(y62D[i,1])  + ", " + aConv.double2string(y63D[i,1])  + ", " + aConv.double2string(y64D[i,1])  + ", " + aConv.double2string(y65D[i,1])  + ", " + aConv.double2string(y66D[i,1])  + ", " + aConv.double2string(y67D[i,1])  + ", " + aConv.double2string(y68D[i,1])  + ", " + aConv.double2string(y69D[i,1])  + ", " + aConv.double2string(y70D[i,1])  + ", " + aConv.double2string(y71D[i,1])  + ", " + aConv.double2string(y72D[i,1])  + ", " + aConv.double2string(y73D[i,1])  + ", " + aConv.double2string(y74D[i,1])  + ", " + aConv.double2string(y75D[i,1])  + ", " + aConv.double2string(y76D[i,1])  + ", " + aConv.double2string(y77D[i,1])  + ", " + aConv.double2string(y78D[i,1])  + ", " + aConv.double2string(y79D[i,1])  + ", " + aConv.double2string(y80D[i,1])  + ", " + aConv.double2string(y81D[i,1])  + ", " + aConv.double2string(y82D[i,1])  + ", " + aConv.double2string(y83D[i,1])  + ", " + aConv.double2string(y84D[i,1])  + ", " + aConv.double2string(y85D[i,1])  + ", " + aConv.double2string(y86D[i,1])  + ", " + aConv.double2string(y87D[i,1])  + ", " + aConv.double2string(y88D[i,1])  + ", " + aConv.double2string(y89D[i,1])  + ", " + aConv.double2string(y90D[i,1])  + ", " + aConv.double2string(y91D[i,1])  + ", " + aConv.double2string(y92D[i,1])  + ", " + aConv.double2string(y93D[i,1])  + ", " + aConv.double2string(y94D[i,1])  + ", " + aConv.double2string(y95D[i,1])  + ", " + aConv.double2string(y96D[i,1])  + ", " + aConv.double2string(y97D[i,1])  + ", " + aConv.double2string(y98D[i,1])  + ", " + aConv.double2string(y99D[i,1])  + ", " + aConv.double2string(y100D[i,1])  + ", " + aConv.double2string(y101D[i,1])  + ", " + aConv.double2string(y102D[i,1])  + ", " + aConv.double2string(y103D[i,1])  + ", " + aConv.double2string(y104D[i,1])  + ", " + aConv.double2string(y105D[i,1])  + ", " + aConv.double2string(y106D[i,1])  + ", " + aConv.double2string(y107D[i,1])  + ", " + aConv.double2string(y108D[i,1])  + ", " + aConv.double2string(y109D[i,1])  + ", " + aConv.double2string(y110D[i,1])  + ", " + aConv.double2string(y111D[i,1])  + ", " + aConv.double2string(y112D[i,1])  + ", " + aConv.double2string(y113D[i,1])  + ", " + aConv.double2string(y114D[i,1])  + ", " + aConv.double2string(y115D[i,1])  + ", " + aConv.double2string(y116D[i,1])  + ", " + aConv.double2string(y117D[i,1])  + ", " + aConv.double2string(y118D[i,1])  + ", " + aConv.double2string(y119D[i,1])  + ", " + aConv.double2string(y120D[i,1])  + ", " + aConv.double2string(y121D[i,1])  + ", " + aConv.double2string(y122D[i,1])  + ", " + aConv.double2string(y123D[i,1])  + ", " + aConv.double2string(y124D[i,1])  + ", " + aConv.double2string(y125D[i,1])  + ", " + aConv.double2string(y126D[i,1])  + ", " + aConv.double2string(y127D[i,1])  + ", " + aConv.double2string(y128D[i,1])  + ", " + aConv.double2string(y129D[i,1])  + ", " + aConv.double2string(y130D[i,1])  + ", " + aConv.double2string(y131D[i,1])  + ", " + aConv.double2string(y132D[i,1])  + ", " + aConv.double2string(y133D[i,1])  + ", " + aConv.double2string(y134D[i,1])  + ", " + aConv.double2string(y135D[i,1])  + ", " + aConv.double2string(y136D[i,1])  + ", " + aConv.double2string(y137D[i,1])  + ", " + aConv.double2string(y138D[i,1])  + ", " + aConv.double2string(y139D[i,1])  + ", " + aConv.double2string(y140D[i,1])  + ", " + aConv.double2string(y141D[i,1])  + ", " + aConv.double2string(y142D[i,1])  + ", " + aConv.double2string(y143D[i,1])  + ", " + aConv.double2string(y144D[i,1])  + ", " + aConv.double2string(y145D[i,1])  + ", " + aConv.double2string(y146D[i,1])  + ", " + aConv.double2string(y147D[i,1])  + ", " + aConv.double2string(y148D[i,1])  + ", " + aConv.double2string(y149D[i,1]));
  }
}

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







