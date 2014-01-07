$.validationEngine.allRules = {
               "required":{ 
						"regex":"none",
						"alertText":"* Ð‘ÑƒÐ´ÑŒ Ð»Ð°ÑÐºÐ°, Ð·Ð°Ð¿Ð¾Ð²Ð½iÑ‚ÑŒ Ñ†Ðµ Ð¿Ð¾Ð»Ðµ",
  						"alertTextTitle":"* Ð‘ÑƒÐ´ÑŒ Ð»Ð°ÑÐºÐ°, Ð²ÐºÐ°Ð¶iÑ‚ÑŒ ",
						"alertTextCheckboxMultiple":"* Please select an option",
						"alertTextCheckboxe":"* This checkbox is required"},
					"or": {
					   "regex":"none",
					   "alertText":"Ð—Ð°Ð¿Ð¾Ð²Ð½iÑ‚ÑŒ Ð¾Ð´Ð½Ðµ Ð· Ñ†Ð¸Ñ… Ð¿Ð¾Ð»iÐ²:",
					   "alertText2":"* ",
					   "alertText3":"Ð°Ð±Ð¾:",
					   "alertTextTitle":"* Ð’ÐºÐ°Ð¶iÑ‚ÑŒ "
					},
					"length":{
						"regex":"none",
						"alertText":"* ÐÐµÐ¾Ð±Ñ…iÐ´Ð½Ð¾ Ð²Ð²ÐµÑÑ‚Ð¸ ",
						"alertText2":" Ð²iÐ´ ",
						"alertText3": " ÑÐ¸Ð¼Ð²Ð¾Ð»iÐ²"},
					"maxCheckbox":{
						"regex":"none",
						"alertText":"* Checks allowed Exceeded"},	
					"minCheckbox":{
						"regex":"none",
						"alertText":"* Ð‘ÑƒÐ´ÑŒ Ð»Ð°ÑÐºÐ°, Ð¾Ð±ÐµÑ€iÑ‚ÑŒ ",
						"alertText2":" Ð²Ð°Ñ€Ð¸Ð°Ð½Ñ‚"},	
					"confirm":{
						"regex":"none",
						"alertText":"* Ð’Ð²ÐµÐ´ÐµÐ½i Ð¿Ð°Ñ€Ð¾Ð»i Ð½Ðµ ÑÐ¿iÐ²Ð¿Ð°Ð´Ð°ÑŽÑ‚ÑŒ"},		
					"telephone":{
						"regex":"/^[0-9\-\(\)\ ]+$/",
						"alertText":"* Invalid phone number"},	
					"email":{
						"regex":"/^[a-zA-Z0-9_\.\-]+\@([a-zA-Z0-9\-]+\.)+[a-zA-Z0-9]{2,4}$/",
						"alertText":"* ÐÐ´Ñ€ÐµÑÑƒ e-mail Ð²Ð²ÐµÐ´ÐµÐ½Ð¾ Ð½ÐµÐ²iÑ€Ð½Ð¾"},	
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
