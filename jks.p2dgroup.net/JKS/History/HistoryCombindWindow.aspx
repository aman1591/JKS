﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HistoryCombindWindow.aspx.cs"
    Inherits="ETC_History_HistoryCombindWindow" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>History Action Window</title>
    <script src="../js/jquery-1.11.0.min.js" type="text/javascript"></script>
    <style>
        #TiffWindow.left
        {
            width: 57% !important;
            float: left;
        }
        #ActionWindow.right
        {
            width: 43% !important;
            float: left;
        }
        /*#SupplierModal { left: 38%; position: absolute; top: 25%; z-index: -1; }*/
        @media (max-width: 800px)
        {
            #TiffWindow.left
            {
                width: 100% !important;
                float: none !important;
            }
            #ActionWindow.right
            {
                width: 100% !important;
                float: none !important;
            }
        }
    </style>

    <script type="text/javascript">
        //
        function setHeight() {
            var documentHeight = 0;

            documentHeight = $(document).height() - 20;

            //if (documentHeight > (screen.height - 145)) {
            //    documentHeight = screen.height - 145;
            //}

            var documentWidth = $(document).width();

            if (documentWidth <= 800) {
                documentHeight = documentHeight / 2;
            }

            var $TiffWindow = $("#<%=TiffWindow.ClientID%>");
            var $ActionWindow = $("#<%=ActionWindow.ClientID%>");

            //var $tDiv = $TiffWindow.find("#ctlTiff").parent();
            //$tDiv.css("height", "100% !important");
            //$tDiv.css("width", "100% !important");

            var h = documentHeight;

            $TiffWindow.css("height", h + "px");
            $ActionWindow.css("height", h + "px");
        };
        //
        function TiffResize() {
            var $TiffWindow = $("#<%=TiffWindow.ClientID%>"); //Tiff Window object of iframe

            //set MySplitter width and height
            var $MySplitter = $TiffWindow.contents().find("#MySplitter"); //container of the tiff image
            var $nav = $TiffWindow.contents().find("#nav"); //nav bar that contain tools

            var th = $TiffWindow.height(); //height of tiff window iframe
            var nh = $nav.height();
            var sh = th - (nh + 35); //extra buffer height deducted from tiff height
            //alert(sh);

            $MySplitter.css("width", "100% !important");
            $MySplitter.height(sh);
            //set MySplitter width and height

            //set RightPane width
            var $LeftPane = $MySplitter.find("#LeftPane");
            var $splitter = $MySplitter.find(".splitbarV");
            var $RightPane = $MySplitter.find("#RightPane");
            var tw = $MySplitter.width();
            var w1 = $LeftPane.width();
            var w2 = $splitter.width();
            var w3 = tw - (w1 + w2) - 2; //deducted 2 for (1600x900, 1440x900, 1400x1050, 1360x768) in IE
            $RightPane.css("width", w3 + "px");
            //set RightPane width

            //set tiffviewer property to fit width, incase it is fit height
            var $1stli = $nav.children().eq(0);
            var $FitUl = $1stli.children().eq(1);
            var $FitWidthLi = $FitUl.children().eq(1);
            var $FitWidtha = $FitWidthLi.children().eq(0);
            $FitWidtha.click();
            //set tiffviewer property to fit width, incase it is fit height

            //resize the selected tiff
            var $SelectedThumb = $LeftPane.find(".SelectedThumb");
            $SelectedThumb.click();
            //resize the selected tiff
        };
        //
        function DelayedSizeChange() {
            var $TiffWindow = $("#<%=TiffWindow.ClientID%>"); //Tiff Window object of iframe
            var $MySplitter = $TiffWindow.contents().find("#MySplitter"); //container of the tiff image

            var th = $TiffWindow.height(); //height of tiff window iframe.
            var sh = $MySplitter.height(); //height of tiff holder in TiffWindow iframe.

            th = th - 35;

            var tw = $TiffWindow.width(); //width of tiff window iframe.
            var sw = $MySplitter.width(); //width of tiff holder in TiffWindow iframe.

            var $LeftPane = $MySplitter.find("#LeftPane");
            var $splitter = $MySplitter.find(".splitbarV");
            var $RightPane = $MySplitter.find("#RightPane");

            var w1 = $LeftPane.width();
            var w2 = $splitter.width();
            var rw = $RightPane.width();

            sw = sw - (w1 + w2) - 2;

            if ((sh > th) || (sw > rw)) {
                //alert(th);
                //alert(sh);
                //alert(sw);
                //alert(rw);
                setHeight();
                TiffResize();
            }
        };
        $(window).ready(function() {
            setHeight();

            setTimeout(function() {
                TiffResize();
                setTimeout(function() {
                    DelayedSizeChange();
                }, 3000);
            }, 3000);
        });
        $(window).resize(function() {
            setTimeout(function() {
                setHeight();
                TiffResize();
            }, 1000);
        });
    </script>
</head>
<body onunload="javascript:CaptureClose();">
    <form id="form1" runat="server">
    <div style="height: auto; width: auto;">
        <iframe class="left" src="" style="top: 100; left: 150;" scrolling="no" frameborder="0"
            marginheight="0px" marginwidth="0px" id="TiffWindow" runat="server"></iframe>
        <iframe class="right" src="" style="top: 100; left: 805;" name="menu" scrolling="yes"
            frameborder="0" marginheight="0px" marginwidth="0px" id="ActionWindow" runat="server">
        </iframe>
        <asp:Button ID="btnNextAction" runat="server" Visible="False"></asp:Button>
    </div>
    </form>
    <script language="javascript" type="text/javascript">
        window.onbeforeunload = WindowCloseHanlder;
        function WindowCloseHanlder() {

            // alert('My CombindWindow is Closing');
            CaptureClose();
        }

        function CaptureClose(sInvoiceID, sDocType) {

            document.body.style.cursor = 'wait';
            window.opener.__doPostBack('btnProcess', '');
            //window.opener.doRefesh();
            //opener.location.reload(true);

        }
    </script>
</body>
</html>
