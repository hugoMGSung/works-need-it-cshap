(function ($) {
    'use strict';

    $(window).load(function () {

        /* Preloader */
        $('#preloader').fadeOut('slow', function () {
            $(this).remove();
        });

        /* Background loading full-size images */
        $('.gallery-item').each(function() {
            var src = $(this).attr('href');
            var img = document.createElement('img');

            img.src = src;
            $('#image-cache').append(img);
        });

        /* Scroll for mobile nav */
        setTimeout (function() {
            if (document.documentElement.clientWidth < 768) {
                var body = $("html, body");
                body.stop().animate({scrollTop:$('#nav').offset().top}, '500', 'swing');
                $.pjax.defaults.scrollTo = $('#nav').offset().top;
            }
        }, 100);

    });

    $(document).ready(function () {

        commonScripts();

        pageScripts();

        /* Ajax page load settings */
        $(document).on('pjax:end', pageScripts);
    });

    /* Set of common scripts */
    function commonScripts() {
        /* Animated Title */
        (function () {
            //set animation timing
            var animationDelay = 3500,
            //loading bar effect
                barAnimationDelay = 3800,
                barWaiting = barAnimationDelay - 3000, //3000 is the duration of the transition on the loading bar - set in the scss/css file
            //letters effect
                lettersDelay = 50,
            //type effect
                typeLettersDelay = 150,
                selectionDuration = 500,
                typeAnimationDelay = selectionDuration + 800,
            //clip effect
                revealDuration = 600,
                revealAnimationDelay = 2500;

            initHeadline();


            function initHeadline() {
                //insert <i> element for each letter of a changing word
                singleLetters($('.cd-headline.letters').find('b'));
                //initialise headline animation
                animateHeadline($('.cd-headline'));
            }

            function singleLetters($words) {
                $words.each(function(){
                    var word = $(this),
                        letters = word.text().split(''),
                        selected = word.hasClass('is-visible');
                    for (var i in letters) {
                        if(word.parents('.rotate-2').length > 0) letters[i] = '<em>' + letters[i] + '</em>';
                        letters[i] = (selected) ? '<i class="in">' + letters[i] + '</i>': '<i>' + letters[i] + '</i>';
                    }
                    var newLetters = letters.join('');
                    word.html(newLetters).css('opacity', 1);
                });
            }

            function animateHeadline($headlines) {
                var duration = animationDelay;
                $headlines.each(function(){
                    var headline = $(this);

                    if(headline.hasClass('loading-bar')) {
                        duration = barAnimationDelay;
                        setTimeout(function(){ headline.find('.cd-words-wrapper').addClass('is-loading') }, barWaiting);
                    } else if (headline.hasClass('clip')){
                        var spanWrapper = headline.find('.cd-words-wrapper'),
                            newWidth = spanWrapper.width() + 10
                        spanWrapper.css('width', newWidth);
                    } else if (!headline.hasClass('type') ) {
                        //assign to .cd-words-wrapper the width of its longest word
                        var words = headline.find('.cd-words-wrapper b'),
                            width = 0;
                        words.each(function(){
                            var wordWidth = $(this).width();
                            if (wordWidth > width) width = wordWidth;
                        });
                        headline.find('.cd-words-wrapper').css('width', width);
                    };

                    //trigger animation
                    setTimeout(function(){ hideWord( headline.find('.is-visible').eq(0) ) }, duration);
                });
            }

            function hideWord($word) {
                var nextWord = takeNext($word);

                if($word.parents('.cd-headline').hasClass('type')) {
                    var parentSpan = $word.parent('.cd-words-wrapper');
                    parentSpan.addClass('selected').removeClass('waiting');
                    setTimeout(function(){
                        parentSpan.removeClass('selected');
                        $word.removeClass('is-visible').addClass('is-hidden').children('i').removeClass('in').addClass('out');
                    }, selectionDuration);
                    setTimeout(function(){ showWord(nextWord, typeLettersDelay) }, typeAnimationDelay);

                } else if($word.parents('.cd-headline').hasClass('letters')) {
                    var bool = ($word.children('i').length >= nextWord.children('i').length) ? true : false;
                    hideLetter($word.find('i').eq(0), $word, bool, lettersDelay);
                    showLetter(nextWord.find('i').eq(0), nextWord, bool, lettersDelay);

                }  else if($word.parents('.cd-headline').hasClass('clip')) {
                    $word.parents('.cd-words-wrapper').animate({ width : '2px' }, revealDuration, function(){
                        switchWord($word, nextWord);
                        showWord(nextWord);
                    });

                } else if ($word.parents('.cd-headline').hasClass('loading-bar')){
                    $word.parents('.cd-words-wrapper').removeClass('is-loading');
                    switchWord($word, nextWord);
                    setTimeout(function(){ hideWord(nextWord) }, barAnimationDelay);
                    setTimeout(function(){ $word.parents('.cd-words-wrapper').addClass('is-loading') }, barWaiting);

                } else {
                    switchWord($word, nextWord);
                    setTimeout(function(){ hideWord(nextWord) }, animationDelay);
                }
            }

            function showWord($word, $duration) {
                if($word.parents('.cd-headline').hasClass('type')) {
                    showLetter($word.find('i').eq(0), $word, false, $duration);
                    $word.addClass('is-visible').removeClass('is-hidden');

                }  else if($word.parents('.cd-headline').hasClass('clip')) {
                    $word.parents('.cd-words-wrapper').animate({ 'width' : $word.width() + 10 }, revealDuration, function(){
                        setTimeout(function(){ hideWord($word) }, revealAnimationDelay);
                    });
                }
            }

            function hideLetter($letter, $word, $bool, $duration) {
                $letter.removeClass('in').addClass('out');

                if(!$letter.is(':last-child')) {
                    setTimeout(function(){ hideLetter($letter.next(), $word, $bool, $duration); }, $duration);
                } else if($bool) {
                    setTimeout(function(){ hideWord(takeNext($word)) }, animationDelay);
                }

                if($letter.is(':last-child') && $('html').hasClass('no-csstransitions')) {
                    var nextWord = takeNext($word);
                    switchWord($word, nextWord);
                }
            }

            function showLetter($letter, $word, $bool, $duration) {
                $letter.addClass('in').removeClass('out');

                if(!$letter.is(':last-child')) {
                    setTimeout(function(){ showLetter($letter.next(), $word, $bool, $duration); }, $duration);
                } else {
                    if($word.parents('.cd-headline').hasClass('type')) { setTimeout(function(){ $word.parents('.cd-words-wrapper').addClass('waiting'); }, 200);}
                    if(!$bool) { setTimeout(function(){ hideWord($word) }, animationDelay) }
                }
            }

            function takeNext($word) {
                return (!$word.is(':last-child')) ? $word.next() : $word.parent().children().eq(0);
            }

            function takePrev($word) {
                return (!$word.is(':first-child')) ? $word.prev() : $word.parent().children().last();
            }

            function switchWord($oldWord, $newWord) {
                $oldWord.removeClass('is-visible').addClass('is-hidden');
                $newWord.removeClass('is-hidden').addClass('is-visible');
            }

        })();

        /* Back to top */
        (function () {
            $("#back-top").hide();

            $(window).scroll(function () {
                if ($(this).scrollTop() > 100) {
                    $('#back-top').fadeIn();
                } else {
                    $('#back-top').fadeOut();
                }
            });

            $('#back-top a').click(function () {
                $('body,html').animate({
                    scrollTop: 0
                }, 600);
                return false;
            });
        })();
    }

    /* Set of page scripts */
    function pageScripts() {

        /* Animated Counter */
        $('.count-container span').counterUp({
            delay: 10, // the delay time in ms
            time: 3000 // the speed time in ms
        });


        /* Magnific Popup */
        $('.gallery-item').magnificPopup({
            type: 'image',
            gallery: {
                enabled: true
            }
        });

        /* Isotope Portfolio */
        (function () {
            var grid = $('.grid').isotope({
                itemSelector: '.grid-item',
                percentPosition: true,
                masonry: {
                    // use outer width of grid-sizer for columnWidth
                    columnWidth: '.grid-sizer'
                }
            });

            grid.imagesLoaded(function () {
                grid.isotope();
            });

            grid.isotope({filter: '*'});

            // filter items on button click
            $('#isotope-filters').on('click', 'a', function () {
                var filterValue = $(this).attr('data-filter');
                grid.isotope({filter: filterValue});
            });

            // filter items on tag click
            $('.post-tag').on('click', 'a', function () {
                var filterValue = $(this).attr('data-filter');
                grid.isotope({filter: filterValue});
                $('#isotope-filters a[data-filter="' + filterValue + '"]').focus();
            });

        })();

        /* Circle Progress */
        (function () {
            function animateElements() {
                $('.progressbar').each(function () {
                    var elementPos = $(this).offset().top;
                    var topOfWindow = $(window).scrollTop();
                    var percent = $(this).find('.circle').attr('data-percent');
                    var percentage = parseInt(percent, 10) / parseInt(100, 10);
                    var animate = $(this).data('animate');
                    if (elementPos < topOfWindow + $(window).height() - 30 && !animate) {
                        $(this).data('animate', true);
                        $(this).find('.circle').circleProgress({
                            startAngle: -Math.PI / 2,
                            value: percent / 100,
                            thickness: 3,
                            fill: {
                                color: '#ffffff'
                            }
                        }).on('circle-animation-progress', function (event, progress, stepValue) {
                            $(this).find('div').text((stepValue * 100).toFixed(1) + "%");
                        }).stop();
                    }
                });
            }

            // Show animated elements
            animateElements();
            $(window).scroll(animateElements);
        })();

        /* Contact Form */
        (function () {
            // Get the form.
            var form = $('#ajax-contact');

            // Get the messages div.
            var formMessages = $('#form-messages');

            // Set up an event listener for the contact form.
            $(form).submit(function (e) {
                // Stop the browser from submitting the form.
                e.preventDefault();

                // Serialize the form data.
                var formData = $(form).serialize();

                // Submit the form using AJAX.
                $.ajax({
                        type: 'POST',
                        url: $(form).attr('action'),
                        data: formData
                    })
                    .done(function (response) {
                        // Make sure that the formMessages div has the 'success' class.
                        $(formMessages).removeClass('alert alert-danger');
                        $(formMessages).addClass('alert alert-success');

                        // Set the message text.
                        $(formMessages).text(response);

                        // Clear the form.
                        $('#name').val('');
                        $('#email').val('');
                        $('#message').val('');
                    })
                    .fail(function (data) {
                        // Make sure that the formMessages div has the 'error' class.
                        $(formMessages).removeClass('alert alert-success');
                        $(formMessages).addClass('alert alert-danger');

                        // Set the message text.
                        if (data.responseText !== '') {
                            $(formMessages).text(data.responseText);
                        } else {
                            $(formMessages).text('Oops! An error occured and your message could not be sent.');
                        }
                    });
            });

        })();

        /* Google map */
        (function () {
            if (!$('#google-map').length) {
                return false;
            }

            initGmap();

            function initGmap() {

                // Create an array of styles.
                var styles = [
                    {
                        stylers: [
                            {saturation: -50}
                        ]
                    }, {
                        featureType: "road",
                        elementType: "geometry",
                        stylers: [
                            {lightness: 100},
                            {visibility: "simplified"}
                        ]
                    }, {
                        featureType: "road",
                        elementType: "labels",
                        stylers: [
                            {visibility: "off"}
                        ]
                    }
                ];

                // Create a new StyledMapType object, passing it the array of styles,
                // as well as the name to be displayed on the map type control.
                var styledMap = new google.maps.StyledMapType(styles, {name: "Styled Map"});

                // Create a map object, and include the MapTypeId to add
                // to the map type control.
                var $latlng = new google.maps.LatLng(52.5075419, 13.4261419),
                    $mapOptions = {
                        zoom: 13,
                        center: $latlng,
                        panControl: false,
                        zoomControl: true,
                        scaleControl: false,
                        mapTypeControl: false,
                        scrollwheel: false,
                        mapTypeControlOptions: {
                            mapTypeIds: [google.maps.MapTypeId.ROADMAP, 'map_style']
                        }
                    };
                var map = new google.maps.Map(document.getElementById('google-map'), $mapOptions);

                google.maps.event.trigger(map, 'resize');

                //Associate the styled map with the MapTypeId and set it to display.
                map.mapTypes.set('map_style', styledMap);
                map.setMapTypeId('map_style');

                var marker = new google.maps.Marker({
                    position: $latlng,
                    map: map,
                    title: ""
                });

            }

        })();

    }


    /* Wow */
    new WOW().init();

    /* Google Analytics */
    (function (i, s, o, g, r, a, m) {
        i['GoogleAnalyticsObject'] = r;
        i[r] = i[r] || function () {(i[r].q = i[r].q || []).push(arguments)};
        i[r].l = 1 * new Date();
        a = s.createElement(o);
        m = s.getElementsByTagName(o)[0];
        a.async = 1;
        a.src = g;
        m.parentNode.insertBefore(a, m);
    })(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');

    ga('create', 'UA-40696437-13', 'auto');
    ga('send', 'pageview');

})(jQuery);
