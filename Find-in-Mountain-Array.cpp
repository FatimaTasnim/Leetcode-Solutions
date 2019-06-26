/**
 * // This is the MountainArray's API interface.
 * // You should not implement it, or speculate about its implementation
 * class MountainArray {
 *   public:
 *     int get(int index);
 *     int length();
 * };
 */
class Solution {
public:
    int findInMountainArray(int target, MountainArray &mountainArr) {
        int low = 0, len, mid, high, midval, left, right, partition=100000000;
        high = mountainArr.length()-1;
        //high--;
        len = high;
        while(low<=high){
            mid = (low + high)/ 2;
            midval = mountainArr.get(mid);
            if(mid-1>=0)left = mountainArr.get(mid-1);
            else {
                partition = mid+1;
                break;
            }
            if(mid+1<=len)right = mountainArr.get(mid+1);
            else {
                partition = mid-1;
                break;
            }
      //  cout << mid << endl;
        if(midval > left && midval<right)low = mid+1;
        else if(midval<left && midval>right) high = mid-1;
        else {
            partition = mid;
            break;
        }
    }
    if(partition == 100000000)partition = mid;
    //cout << "Here I am " << partition << endl;
    // Search in left partition

    low = 0; high = partition;

    while(low<=high){
        mid = (low + high)/ 2;
        midval = mountainArr.get(mid);
        if(midval<target)low = mid+1;
        else if (midval>target) high = mid-1;
        else {
        //	cout << midval << endl;
            return mid;
        }
    }

    // as target not found in left partition search in right partition

    low = partition, high = len;

    while(low<=high){
        mid = (low + high)/ 2;
        midval = mountainArr.get(mid);
        if(midval>target)low = mid+1;
        else if(midval<target)high = mid-1;
        else {
        //	cout << midval << endl;
        	return mid;
        }
    }

    return -1;
    }
};
