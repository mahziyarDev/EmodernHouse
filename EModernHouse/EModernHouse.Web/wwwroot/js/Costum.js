function open_waiting(selector = 'body') {
    $(selector).waitMe({
        effect: 'facebook',
        text: 'لطفا صبر کنید ...',
        bg: 'rgba(255,255,255,0.7)',
        color: '#000'
    });
}

function close_waiting(selector = 'body') {
    $(selector).waitMe('hide');
}


function ShowMessage(title, text, theme) {
    window.createNotification({
        closeOnClick: true,
        displayCloseButton: false,
        positionClass: 'nfc-bottom-right',
        showDuration: 7000,
        theme: theme !== '' ? theme : 'success'

    })({
        title: title !== '' ? title : 'اعلان',
        message:decodeURI(text)
    });
}

/*for ckEditors*/

$(document).ready(function () {
    var editors = $("[ckeditor]");
    if (editors.length > 0) {
        $.getScript('/js/ckeditor.js',
            function () {
                $(editors).each(function (index, value) {
                    var id = $(value).attr('ckeditor');
                    ClassicEditor.create(document.querySelector('[ckeditor="' + id + '"]'),
                        {
                            toolbar: {
                                items: [
                                    'heading',
                                    '|',
                                    'bold',
                                    'italic',
                                    'link',
                                    '|',
                                    'fontSize',
                                    'fontColor',
                                    '|',
                                    'imageUpload',
                                    'blockQuote',
                                    'insertTable',
                                    'undo',
                                    'redo',
                                    'codeBlock'
                                ]
                            },
                            language: 'fa',
                            table: {
                                contentToolbar: [
                                    'tableColumn',
                                    'tableRow',
                                    'mergeTableCells'
                                ]
                            },
                            licenseKey: '',
                            simpleUpload: {
                                // The URL that the images are uploaded to.
                                uploadUrl: '/Uploader/UploadImage'
                            }

                        })
                        .then(editor => {
                            window.editor = editor;
                        }).catch(err => {
                            console.error(err);
                        });
                });
            });
    }
});

//for select color
function changeProductBaseColor(colorId,colorPrice, colorName) {
        $("#clearToman").hide();
        var basePrice = parseInt($("#productBasePrice").val(), 0);
        $(".product-price-raw").html((basePrice + colorPrice) + "تومان" + '(' + colorName + ')');
        $("#Add-Product_to_Order_ProductColorId").val(colorId);
}

function ChangeCountOfProduct(e) {
    var numberOfProduct = parseInt(e.target.value, 0);
    $("#Add-Product_to_Order_Count").val(numberOfProduct);
}

function onSuccessAddProductToOrder(res) {
    if (res.status === 'Success') {
        ShowMessage('اعلان', res.message);
    }
    if (res.status === "Warning") {
        ShowMessage('اعلان', res.message, 'warning');
    }
    if (res.status === "Danger") {
        ShowMessage('اعلان', res.message, 'Danger');
    }
    setTimeout(function() {
        close_waiting();
    }, 2000);
}


$("#AddProductToCardSubmit").on('click',
    function(e) {
        e.preventDefault();
        $("#AddProductToCardForm").submit();
        open_waiting();
    });
//for product Archive
$('.btn-filter-sidebar').on('click', function () {
    $('.filter-options-sidebar').addClass('toggled');
});
$('.btn-close-filter-sidebar').on('click', function () {
    $('.filter-options-sidebar').removeClass('toggled');
});

if ($('.search-in-options').length) {
    $(".search-in-options input[type=text]").on("keyup", function () {
        var value = $(this).val();
        $(this).parents('.search-in-options').siblings('.widget-content').find('.container-checkbox').filter(function () {
            $(this).toggle($(this).text().indexOf(value) > -1);
        });
    });
}

function sendPage(page) {
    $("#pageId").val(page);
    $("#formFilter").submit();
}
//end product Archive

//function AddToInterestProduct(productId) {
//    $.get("/add-to-product-Interest/" + productId).then(res => {
//        if (res.status === 'Success') {
//            ShowMessage("علاقه مندی", "با موفقیت به علاقه مندی های شما اضافه شد", 'success');
//        } else {
//            ShowMessage("اعلان", "نمی توانم این محصول را به علاقه مندی هایتان اضافه نماییم", "error");
//        }
//    });

//}
$('[Addinterest]').on('click',function(e) {
    e.preventDefault();
    var url = $(this).attr("href");
    var id = $(this).attr('Addinterest');

    var address = `${"add-to-product-Interest/" + id}`;
    console.log(address);
    $.get(address).then(res => {
        if (res.status === 'Success') {
            ShowMessage("علاقه مندی", res.message, 'success');
        } else {
            ShowMessage("اعلان", res.message, "error");
        }
    });
});