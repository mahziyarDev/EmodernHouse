function ShowMessage(title, text, theme) {
    window.createNotification({
        closeOnClick: true,
        displayCloseButton: false,
        positionClass: 'nfc-bottom-right',
        showDuration: 7000,
        theme: theme !== '' ? theme : 'success'

    })({
        title: title !== '' ? title : 'اعلان',
        message: decodeURI(text)
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

$('[ajax-url-button]').on('click', function (e) {
    e.preventDefault();
    var url = $(this).attr('href');
    var itemId = $(this).attr('ajax-url-button');
    console.log(itemId);
    swal({
        title: 'اخطار',
        text: "آیا از انجام عملیات مورد نظر اطمینان دارید؟",
        type: "warning",
        showCancelButton: true,
        confirmButtonClass: "btn-danger",
        confirmButtonText: "بله",
        cancelButtonText: "خیر",
        closeOnConfirm: false,
        closeOnCancel: false
    }).then((result) => {
        if (result.value) {
            $.get(url).then(result => {
                if (result.status === 'Success') {
                    ShowMessage("موفقیت", result.message, "success", 3000);
                    $('#ajax-url-item-' + itemId).hide(1500);
                }
            });
        } else if (result.dismiss === swal.DismissReason.cancel) {
            swal('توجه', 'عملیات لغو شد', 'error');
        }
    });
});

//for categories 
$(document).ready(function () {
   // $('[main_categories_checkbox]>div').hide();
    $('[main_categories_checkbox]').on('change',
        function (e) {

            var IsChecked = $(this).is(':checked');
            var selectedCategoryId = $(this).attr('main_categories_checkbox');
            var SelectedLastCategoryId = $('[firs-parent-category]').attr('firs-parent-category');
            if (IsChecked) {
                $('#firs-parent-categories-' + selectedCategoryId).slideDown(300);
            } else {
                $('#firs-parent-categories-' + selectedCategoryId).slideUp(300);
                $('[firs-parent-category1="' + selectedCategoryId + '"]').prop('checked', false);
                $('#last-categories-' + SelectedLastCategoryId).slideUp(300);
                $('[two-parent-categories="' + SelectedLastCategoryId + '"]').prop('checked', false);
            }
        });

    $('[firs-parent-category]').on('change',
        function (e) {
            var isCheckedParent = $(this).is(':checked');
            var SelectedLastCategoryId = $(this).attr('firs-parent-category');
            if (isCheckedParent) {
                $('#last-categories-' + SelectedLastCategoryId).slideDown(300);
            } else {
                $('#last-categories-' + SelectedLastCategoryId).slideUp(300);
                $('[two-parent-categories="' + SelectedLastCategoryId + '"]').prop('checked', false);
            }
        });
});

//for product colors


$('#btn-add-colors').on('click',
    function (e) {
        e.preventDefault();
        var colorName = $('#product-color-names-input').val();
        var colorCodes = $('#product-color-code-input').val();
        var colorPrice = $('#product-color-price-input').val();
        
        if (colorName !== "" && colorCodes !== "" && colorPrice !== "") {
            
            var unic = ($('#list-of-product-colors tr')).length;
            // create input hidden
            var input_ColorName = `<input type="hidden" value="${colorName}" name="ProductColor[${unic}].ColorName" color_name_hidden_inputs="${unic}"/>`;
            var input_ColorCode = `<input type="hidden" value="${colorCodes}" name="ProductColor[${unic}].ColorCode" color_Code_hidden_inputs="${unic}"/>`;
            var input_ColorPrice = `<input type="hidden" value="${colorPrice}" name="ProductColor[${unic}].Price" color_Price_hidden_inputs="${unic}"/>`;
            // send to form
            var formProduct = $('#form_Product');
            formProduct.append(input_ColorName);
            formProduct.append(input_ColorCode);
            formProduct.append(input_ColorPrice);

            //create td for table
            
            var ColorNameTBL = `<td>${colorName}</td>`;
            var ColorCodeTBL = `<td style="background:${colorCodes};color:#000">${colorCodes}</td>`;
            var ColorPriceTBL = `<td>${colorPrice}</td>`;
            //var RemoveTrAndInputs = `<td><a class="text-white btn btn-danger" onclick="remove_ColorItems(${unic})">حذف</a></td>`;
            var InsertToTBL = `<tr color_table_item="${unic}">${ColorNameTBL} ${ColorCodeTBL} ${ColorPriceTBL}</tr>`;
            $('#list-of-product-colors').append(InsertToTBL);
            
            colorName.val("");
            colorCodes.val("");
            colorPrice.val("");
          
        } else {
            ShowMessage("تذکر", "فیلد رنگ و کد رنگ و قیمت رنگ باید پر شود", 'warning', 3000);
        }

    });

function remove_ColorItems() {
    
    $('#list-of-product-colors tr').remove();
    $('[color_name_hidden_inputs]').remove();
    $('[color_Code_hidden_inputs]').remove();
    $('[color_Price_hidden_inputs]').remove();
}