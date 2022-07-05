//Fixed Size Window
// while (j < array.Length)
// {
//     calculation;

//     if (window size < k)
//     {
//         j++;
//     }

//     if (window size == k)
//     {
//         Answer calculation;
//         Remove calculation for i
//         Window size maintain
//         i++;            //slide the window
//         j++;    
//     }
// }
// return Answer

// --------------------------------------------------

//Variable Size Window

// while (j< size)
// {
//     calculation

//     if (condition<k)
//     {
//         j++
//     }
//     else if (condition == k)
//     {
//         answer calculation;
//         j++;
//     }
//     else if (condition > k)
//     {
//         while (condition > k)
//         {
//             remove calculation for i
//             i++;
//         }
//         j++;
//     }
// }
// return answer;