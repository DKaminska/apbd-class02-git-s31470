namespace StatisticsHelper {
	//something here in namespace 
	public class StatisticsHelper {
	 public void CalculateMax(int[] values){
	 //main changes
	 }
<<<<<<< HEAD
	 //random comment THIS IS MAIN COMMENT CHANGE YAEAHJ
=======
	 //random comment THIS IS AWESOME FEATURE-CONFLICT CHANGE
>>>>>>> feature-conflict
	 public int CalculateMin(int[] values){
		int result = values[0];
		for(int i=0;i<values.size;i++){
			if(result>values[i]){
				result = values[i];
			}
		}
		return result;
	 }
	}
}