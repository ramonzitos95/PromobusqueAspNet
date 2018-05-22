﻿
$(function () {
    //$('.button-collapse').sideNav();
    $('.button-collapse').sideNav({
        menuWidth: 450, // Default is 300
        edge: 'left', // Choose the horizontal origin
        closeOnClick: true, // Closes side-nav on <a> clicks, useful for Angular/Meteor
        draggable: true, // Choose whether you can drag to open on touch screens,
        onOpen: function (el) {
        },
        onClose: function (el) {
        }
    });
});
