$(document).ready(function() {
	$(".toggle a.question").click(function (event) {
		event.preventDefault(); 
		$(this).toggleClass("act");
		$(this).next("div.answer").slideToggle("fast");
	});
});
$(function() {
        $('#slider').nivoSlider();
});

/*anythingSlider**/
$(function(){
	$('#slider2').anythingSlider({
		resizeContents      : false, // If true, solitary images/objects in the panel will expand to fit the viewport
		navigationSize      : 3,     // Set this to the maximum number of visible navigation tabs; false to disable
		navigationFormatter : function(index, panel){ // Format navigation labels with text
			return ['Recipe', 'Quote', 'Image', 'Quote #2', 'Image #2'][index - 1];
		},
		onSlideComplete: function(slider) {
			// keep the current navigation tab in view
			slider.navWindow( slider.currentPage );
		},
	});

});

jQuery().ready(function(){
		// simple accordion
		jQuery('#list1a').accordion();
		jQuery('#list1b').accordion({
			autoheight: false
		});
		
		// second simple accordion with special markup
		jQuery('#navigation').accordion({
			active: false,
			header: '.head',
			navigation: true,
			event: 'mouseover',
			fillSpace: true,
			animated: 'easeslide'
		});
		
		// highly customized accordion
		jQuery('#list2').accordion({
			event: 'mouseover',
			active: '.selected',
			selectedClass: 'active',
			animated: "bounceslide",
			header: "dt"
		}).bind("change.ui-accordion", function(event, ui) {
			jQuery('<div>' + ui.oldHeader.text() + ' hidden, ' + ui.newHeader.text() + ' shown</div>').appendTo('#log');
		});
		
		// first simple accordion with special markup
		jQuery('#list3').accordion({
			header: 'div.title',
			active: false,
			alwaysOpen: false,
			animated: false,
			autoheight: false
		});
		
		var wizard = $("#wizard").accordion({
			header: '.title',
			event: false
		});
		
		var wizardButtons = $([]);
		$("div.title", wizard).each(function(index) {
			wizardButtons = wizardButtons.add($(this)
			.next()
			.children(":button")
			.filter(".next, .previous")
			.click(function() {
				wizard.accordion("activate", index + ($(this).is(".next") ? 1 : -1))
			}));
		});
		
		// bind to change event of select to control first and seconds accordion
		// similar to tab's plugin triggerTab(), without an extra method
		var accordions = jQuery('#list1a, #list1b, #list2, #list3, #navigation, #wizard');
		
		jQuery('#switch select').change(function() {
			accordions.accordion("activate", this.selectedIndex-1 );
		});
		jQuery('#close').click(function() {
			accordions.accordion("activate", -1);
		});
		jQuery('#switch2').change(function() {
			accordions.accordion("activate", this.value);
		});
		jQuery('#enable').click(function() {
			accordions.accordion("enable");
		});
		jQuery('#disable').click(function() {
			accordions.accordion("disable");
		});
		jQuery('#remove').click(function() {
			accordions.accordion("destroy");
			wizardButtons.unbind("click");
		});
	});
	
/*Tabs*/
$(function() {	  
	  $("#tab").organicTabs({
		  "speed": 200
	  });

  });