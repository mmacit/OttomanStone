$.validationEngine.allRules = {
               "required":{ 
						"regex":"none",
						"alertText":"* ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹Ñ‚Ð°, Ð·Ð°Ð¿Ð¾Ð»Ð½Ð¸Ñ‚Ðµ ÑÑ‚Ð¾ Ð¿Ð¾Ð»Ðµ",
  						"alertTextTitle":"* ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹Ñ‚Ð°, ÑƒÐºÐ°Ð¶Ð¸Ñ‚Ðµ ",
						"alertTextCheckboxMultiple":"* Please select an option",
						"alertTextCheckboxe":"* This checkbox is required"},
					"or": {
					   "regex":"none",
					   "alertText":"Ð—Ð°Ð¿Ð¾Ð»Ð½Ð¸Ñ‚Ðµ Ð¾Ð´Ð½Ð¾ Ð¸Ð· ÑÑ‚Ð¸Ñ… Ð¿Ð¾Ð»ÐµÐ¹:",
					   "alertText2":"* ",
					   "alertText3":"Ð¸Ð»Ð¸:",
					   "alertTextTitle":"* Ð£ÐºÐ°Ð¶Ð¸Ñ‚Ðµ "
					},
					"length":{
						"regex":"none",
						"alertText":"* ÐÐµÐ¾Ð±Ñ…Ð¾Ð´Ð¸Ð¼Ð¾ Ð²Ð²ÐµÑÑ‚Ð¸ Ð¾Ñ‚",
						"alertText2":" Ð´Ð¾ ",
						"alertText3": " ÑÐ¸Ð¼Ð²Ð¾Ð»Ð¾Ð²"},
					"maxCheckbox":{
						"regex":"none",
						"alertText":"* Checks allowed Exceeded"},	
					"minCheckbox":{
						"regex":"none",
						"alertText":"* ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð²Ñ‹Ð±ÐµÑ€Ð¸Ñ‚Ðµ ",
						"alertText2":" Ð²Ð°Ñ€Ð¸Ð°Ð½Ñ‚"},	
					"confirm":{
						"regex":"none",
						"alertText":"* Ð’Ð²ÐµÐ´ÐµÐ½Ð½Ñ‹Ðµ Ð¿Ð°Ñ€Ð¾Ð»Ð¸ Ð½Ðµ ÑÐ¾Ð²Ð¿Ð°Ð´Ð°ÑŽÑ‚"},		
					"telephone":{
						"regex":"/^[0-9\-\(\)\ ]+$/",
						"alertText":"* Invalid phone number"},	
					"email":{
						"regex":"/^[a-zA-Z0-9_\.\-]+\@([a-zA-Z0-9\-]+\.)+[a-zA-Z0-9]{2,4}$/",
						"alertText":"* ÐÐ´Ñ€ÐµÑ e-mail Ð²Ð²ÐµÐ´ÐµÐ½ Ð½ÐµÐ²ÐµÑ€Ð½Ð¾"},	
					"date":{
                         "regex":"/^[0-9]{4}\-\[0-9]{1,2}\-\[0-9]{1,2}$/",
                         "alertText":"* Invalid date, must be in YYYY-MM-DD format"},
					"onlyNumber":{
						"regex":"/^[0-9\ ]+$/",
						"alertText":"* Numbers only"},	
					"noSpecialCaracters":{
						"regex":"/^[0-9a-zA-Z]+$/",
						"alertText":"* No special caracters allowed"},	
					"ajaxUser":{
						"file":"validateUser.php",
						"alertTextOk":"* This user is available",	
						"alertTextLoad":"* Loading, please wait",
						"alertText":"* This user is already taken"},	
					"ajaxName":{
						"file":"validateUser.php",
						"alertText":"* This name is already taken",
						"alertTextOk":"* This name is available",	
						"alertTextLoad":"* Loading, please wait"},		
					"onlyLetter":{
						"regex":"/^[a-zA-Z\ \']+$/",
						"alertText":"* Letters only"}
					}	
