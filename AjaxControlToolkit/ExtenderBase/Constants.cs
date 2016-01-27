namespace AjaxControlToolkit {

    public static class Constants {

        public const string
            CdnPrefix = "//ajax.aspnetcdn.com/ajax/act/15_1_4/";

        internal const string
            CdnScriptDebugPrefix = CdnPrefix + "Scripts/AjaxControlToolkit/Debug/",
            CdnScriptReleasePrefix = CdnPrefix + "Scripts/AjaxControlToolkit/Release/",

            JsPostfix = ".js",
            DebugJsPostfix = ".debug" + JsPostfix,

            CssPostfix = ".css",
            MinCssPostfix = ".min" + CssPostfix,

            IconPostfix = ".ico",

            ContentVirtualPath = "~/Content/AjaxControlToolkit/",
            StylesVirtualPath = ContentVirtualPath + "Styles/",
            ImagesVirtualPath = ContentVirtualPath + "Images/",
            ScriptsVirtualPath = "~/Scripts/AjaxControlToolkit/",
            ScriptsDebugVirtualPath = ScriptsVirtualPath + "Debug/",
            ScriptsReleaseVirtualPath = ScriptsVirtualPath + "Release/",

            ImageResourcePrefix = "AjaxControlToolkit.Images.",
            StyleResourcePrefix = "AjaxControlToolkit.Styles.",

            BackgroundStylesName = "Backgrounds",
            BaseScriptName = "BaseScripts",
            CommonScriptName = "Common",
            CompatDragDropScriptName = "Compat.DragDrop",
            CompatTimerScriptName = "Compat.Timer",
            ComponentSetName = "ComponentSet",
            DateTimeScriptName = "Common.DateTime",
            LocalizationScriptName = "Localization.Resources",
            ThreadingScriptName = "Common.Threading",

            AccordionName = "Accordion",
            AjaxFileUploadName = "AjaxFileUpload",
            AlwaysVisibleControlName = "AlwaysVisibleControl",
            AnimationName = "Animation",
            AnimationScriptsName = "AnimationScripts",
            AreaChartName = "AreaChart",
            AsyncFileUploadName = "AsyncFileUpload",
            AutoCompleteName = "AutoComplete",
            BalloonPopupName = "BalloonPopup",
            BarChartName = "BarChart",
            BubbleChartName = "BubbleChart",
            CalendarName = "Calendar",
            CascadingDropDownName = "CascadingDropDown",
            CollapsiblePanelName = "CollapsiblePanel",
            ColorPickerName = "ColorPicker",
            ConfirmButtonName = "ConfirmButton",
            ComboBoxName = "ComboBox",
            DynamicPopulateName = "DynamicPopulate",
            DraggableListItemName = "DraggableListItem",
            DragPanelName = "DragPanel",
            DropDownName = "DropDown",
            DropShadowName = "DropShadow",
            DropWatcherName = "DropWatcher",
            FilteredTextBoxName = "FilteredTextBox",
            FloatingBehaviorName = "FloatingBehavior",
            GravatarName = "Gravatar",
            HoverMenuName = "HoverMenu",
            HoverName = "Hover",
            HtmlEditorExtenderName = "HtmlEditorExtender",
            LineChartName = "LineChart",
            ListSearchName = "ListSearch",
            MaskedEditName = "MaskedEdit",
            MaskedEditValidatorName = "MaskedEditValidator",
            ModalPopup = "ModalPopup",
            MultiHandleSliderName = "MultiHandleSlider",
            MutuallyExclusiveCheckBoxName = "MutuallyExclusiveCheckBox",
            NoBotName = "NoBot",
            NumericUpDownName = "NumericUpDown",
            PagingBulletedListName = "PagingBulletedList",
            PasswordStrengthName = "PasswordStrength",
            PieChartName = "PieChart",
            PopupControlName = "PopupControl",
            PopupName = "Popup",
            RatingName = "Rating",
            ReorderListName = "ReorderList",
            ResizableControlName = "ResizableControl",
            RoundedCornersName = "RoundedCorners",
            SeadragonName = "Seadragon",
            SliderName = "Slider",
            SlideShowName = "SlideShow",
            TabsName = "Tabs",
            TextBoxWatermarkName = "TextBoxWatermark",
            ToggleButtonName = "ToggleButton",
            TwitterName = "Twitter",
            UpdatePanelAnimationName = "UpdatePanelAnimation",
            ValidatorCalloutName = "ValidatorCallout",

            AsyncFileUploadImage = AsyncFileUploadName + ".Button.png",

            HtmlEditorName = "HtmlEditor",
            HtmlEditorPopupsName = HtmlEditorName + ".Popups",
            HtmlEditorToolbarButtonsName = HtmlEditorName + ".ToolbarButtons",
            HtmlEditorHtmlEditorName = HtmlEditorName + ".HtmlEditor",

            HtmlEditorEditorName = HtmlEditorName + ".Editor",
            HtmlEditorToolbarName = HtmlEditorName + ".Toolbar",
            HtmlEditorEnumsName = HtmlEditorName + ".Enums",
            HtmlEditorEventsName = HtmlEditorName + ".Events",
            HtmlEditorPreviewPanelName = HtmlEditorName + ".PreviewPanel",
            HtmlEditorModePanelName = HtmlEditorName + ".ModePanel",
            HtmlEditorEditPanelName = HtmlEditorName + ".EditPanel",
            HtmlEditorHtmlPanelName = HtmlEditorName + ".HtmlPanel",
            HtmlEditorDocumentName = HtmlEditorName + ".Document",
            HtmlEditorDesignPanelName = HtmlEditorName + ".DesignPanel",
            HtmlEditorExecCommandEmulationName = HtmlEditorName + ".ExecCommandEmulation",
            HtmlEditorDesignPanelEventHandlerName = HtmlEditorName + ".DesignPanelEventHandler",

            HtmlEditorPopupName = HtmlEditorPopupsName + ".Popup",
            HtmlEditorAttachedTemplatePopupName = HtmlEditorPopupsName + ".AttachedTemplatePopup",
            HtmlEditorAttachedPopupName = HtmlEditorPopupsName + ".AttachedPopup",
            HtmlEditorPopupCommandButtonName = HtmlEditorPopupsName + ".PopupCommonButton",
            HtmlEditorPopupBoxButtonName = HtmlEditorPopupsName + ".PopupBoxButton",
            HtmlEditorPopupBGIButtonName = HtmlEditorPopupsName + ".PopupBGIButton",
            HtmlEditorOkCancelAttachedTemplatePopupName = HtmlEditorPopupsName + ".OkCancelAttachedTemplatePopup",
            HtmlEditorLinkPropertiesName = HtmlEditorPopupsName + ".LinkProperties",
            HtmlEditorBaseColorsPopupName = HtmlEditorPopupsName + ".BaseColorsPopup",

            HtmlEditorBackColorClearButtonName = HtmlEditorToolbarButtonsName + ".BackColorClear",
            HtmlEditorBackColorSelectorButtonName = HtmlEditorToolbarButtonsName + ".BackColorSelector",
            HtmlEditorBoldButtonName = HtmlEditorToolbarButtonsName + ".Bold",
            HtmlEditorBoxButtonName = HtmlEditorToolbarButtonsName + ".BoxButton",
            HtmlEditorBulletedListButtonName = HtmlEditorToolbarButtonsName + ".BulletedList",
            HtmlEditorColorButtonName = HtmlEditorToolbarButtonsName + ".ColorButton",
            HtmlEditorColorSelectorName = HtmlEditorToolbarButtonsName + ".ColorSelector",
            HtmlEditorCommonButtonName = HtmlEditorToolbarButtonsName + ".CommonButton",
            HtmlEditorCopyButtonName = HtmlEditorToolbarButtonsName + ".Copy",
            HtmlEditorCutButtonName = HtmlEditorToolbarButtonsName + ".Cut",
            HtmlEditorDecreaseIndentButtonName = HtmlEditorToolbarButtonsName + ".DecreaseIndent",
            HtmlEditorDesignModeButtonName = HtmlEditorToolbarButtonsName + ".DesignMode",
            HtmlEditorDesignModeBoxButtonName = HtmlEditorToolbarButtonsName + ".DesignModeBoxButton",
            HtmlEditorDesignModeImageButtonName = HtmlEditorToolbarButtonsName + ".DesignModeImageButton",
            HtmlEditorDesignModePopupImageButtonName = HtmlEditorToolbarButtonsName + ".DesignModePopupImageButton",
            HtmlEditorDesignModeSelectButtonName = HtmlEditorToolbarButtonsName + ".DesignModeSelectButton",
            HtmlEditorToggleButtonName = HtmlEditorToolbarButtonsName + ".EditorToggleButton",
            HtmlEditorFixedBackColorButtonName = HtmlEditorToolbarButtonsName + ".FixedBackColor",
            HtmlEditorFixedColorButtonName = HtmlEditorToolbarButtonsName + ".FixedColorButton",
            HtmlEditorFixedForeColorButtonName = HtmlEditorToolbarButtonsName + ".FixedForeColor",
            HtmlEditorFontNameButtonName = HtmlEditorToolbarButtonsName + ".FontName",
            HtmlEditorFontSizeButtonName = HtmlEditorToolbarButtonsName + ".FontSize",
            HtmlEditorForeColorButtonName = HtmlEditorToolbarButtonsName + ".ForeColor",
            HtmlEditorForeColorClearButtonName = HtmlEditorToolbarButtonsName + ".ForeColorClear",
            HtmlEditorForeColorSelectorButtonName = HtmlEditorToolbarButtonsName + ".ForeColorSelector",
            HtmlEditorHorizontalSepearatorButtonName = HtmlEditorToolbarButtonsName + ".HorizontalSeparator",
            HtmlEditorHtmlModeButtonName = HtmlEditorToolbarButtonsName + ".HtmlMode",
            HtmlEditorImageButtonName = HtmlEditorToolbarButtonsName + ".ImageButton",
            HtmlEditorIncreaseIndentButtonName = HtmlEditorToolbarButtonsName + ".IncreaseIndent",
            HtmlEditorInsertHRButtonName = HtmlEditorToolbarButtonsName + ".InsertHR",
            HtmlEditorInsertLinkButtonName = HtmlEditorToolbarButtonsName + ".InsertLink",
            HtmlEditorItalicButtonName = HtmlEditorToolbarButtonsName + ".Italic",
            HtmlEditorJustifyCenterButtonName = HtmlEditorToolbarButtonsName + ".JustifyCenter",
            HtmlEditorJustifyFullButtonName = HtmlEditorToolbarButtonsName + ".JustifyFull",
            HtmlEditorJustifyRightButtonName = HtmlEditorToolbarButtonsName + ".JustifyRight",
            HtmlEditorJustifyLeftButtonName = HtmlEditorToolbarButtonsName + ".JustifyLeft",
            HtmlEditorLtrButtonName = HtmlEditorToolbarButtonsName + ".Ltr",
            HtmlEditorMethodButtonName = HtmlEditorToolbarButtonsName + ".MethodButton",
            HtmlEditorModeButtonName = HtmlEditorToolbarButtonsName + ".ModeButton",
            HtmlEditorOkCancelPopupButtonName = HtmlEditorToolbarButtonsName + ".OkCancelPopupButton",
            HtmlEditorOrderedListButtonName = HtmlEditorToolbarButtonsName + ".OrderedList",
            HtmlEditorParagraphButtonName = HtmlEditorToolbarButtonsName + ".Paragraph",
            HtmlEditorPasteButtonName = HtmlEditorToolbarButtonsName + ".Paste",
            HtmlEditorPasteTextButtonName = HtmlEditorToolbarButtonsName + ".PasteText",
            HtmlEditorPasteWordButtonName = HtmlEditorToolbarButtonsName + ".PasteWord",
            HtmlEditorPreviewModeButtonName = HtmlEditorToolbarButtonsName + ".PreviewMode",
            HtmlEditorRedoButtonMode = HtmlEditorToolbarButtonsName + ".Redo",
            HtmlEditorRemoveAlignmentButtonName = HtmlEditorToolbarButtonsName + ".RemoveAlignment",
            HtmlEditorRemoveLinkButtonName = HtmlEditorToolbarButtonsName + ".RemoveLink",
            HtmlEditorRemoveStylesButtonName = HtmlEditorToolbarButtonsName + ".RemoveStyles",
            HtmlEditorRtlButtonName = HtmlEditorToolbarButtonsName + ".Rtl",
            HtmlEditorSelectButtonName = HtmlEditorToolbarButtonsName + ".SelectButton",
            HtmlEditorSelectorButtonName = HtmlEditorToolbarButtonsName + ".Selector",
            HtmlEditorStrikeThroughButtonName = HtmlEditorToolbarButtonsName + ".StrikeThrough",
            HtmlEditorSubScriptButtonName = HtmlEditorToolbarButtonsName + ".SubScript",
            HtmlEditorSuperScriptButtonName = HtmlEditorToolbarButtonsName + ".SuperScript",
            HtmlEditorUnderlineButtonName = HtmlEditorToolbarButtonsName + ".Underline",
            HtmlEditorUndoButtonName = HtmlEditorToolbarButtonsName + ".Undo",

            HtmlEditorBgiButtonImage = HtmlEditorName + ".BgiButton.gif",
            HtmlEditorEdColorBgClearNImage = HtmlEditorName + ".Ed-ColorBgClear-Inactive.gif",
            HtmlEditorEdColorBgClearAImage = HtmlEditorName + ".Ed-ColorBgClear-Active.gif",
            HtmlEditorEdFormatBoldAImage = HtmlEditorName + ".Ed-FormatBold-Active.gif",
            HtmlEditorEdFormatBoldNImage = HtmlEditorName + ".Ed-FormatBold-Inactive.gif",
            HtmlEditorEdListBulletAImage = HtmlEditorName + ".Ed-ListBullet-Active.gif",
            HtmlEditorEdListBulletNImage = HtmlEditorName + ".Ed-ListBullet-Inactive.gif",
            HtmlEditorEdCopyAImage = HtmlEditorName + ".Ed-Copy-Active.gif",
            HtmlEditorEdCopyNImage = HtmlEditorName + ".Ed-Copy-Inactive.gif",
            HtmlEditorEdCutAImage = HtmlEditorName + ".Ed-Cut-Active.gif",
            HtmlEditorEdCutNImage = HtmlEditorName + ".Ed-Cut-Inactive.gif",
            HtmlEditorEdIndentLessAImage = HtmlEditorName + ".Ed-IndentLess-Active.gif",
            HtmlEditorEdIndentLessNImage = HtmlEditorName + ".Ed-IndentLess-Inactive.gif",
            HtmlEditorEdDesignAImage = HtmlEditorName + ".Ed-Design-Active.gif",
            HtmlEditorEdDesignNImage = HtmlEditorName + ".Ed-Design-Inactive.gif",
            HtmlEditorEdBackColorAImage = HtmlEditorName + ".Ed-BackColor-Active.gif",
            HtmlEditorEdBackColorNImage = HtmlEditorName + ".Ed-BackColor-Inactive.gif",
            HtmlEditorEdForeColorAImage = HtmlEditorName + ".Ed-ForeColor-Active.gif",
            HtmlEditorEdForeColorNImage = HtmlEditorName + ".Ed-ForeColor-Inactive.gif",
            HtmlEditorEdColorFgAImage = HtmlEditorName + ".Ed-ColorFg-Active.gif",
            HtmlEditorEdColorFgNImage = HtmlEditorName + ".Ed-ColorFg-Inactive.gif",
            HtmlEditorEdColorFgClearAImage = HtmlEditorName + ".Ed-ColorFgClear-Active.gif",
            HtmlEditorEdColorFgClearNImage = HtmlEditorName + ".Ed-ColorFgClear-Inactive.gif",
            HtmlEditorEdSepImage = HtmlEditorName + ".Ed-Separator.gif",
            HtmlEditorEdHtmlAImage = HtmlEditorName + ".Ed-Html-Active.gif",
            HtmlEditorEdHtmlNImage = HtmlEditorName + ".Ed-Html-Inactive.gif",
            HtmlEditorEdIndentMoreAImage = HtmlEditorName + ".Ed-IndentMore-Active.gif",
            HtmlEditorEdIndentMoreNImage = HtmlEditorName + ".Ed-IndentMore-Inactive.gif",
            HtmlEditorEdRuleAImage = HtmlEditorName + ".Ed-Rule-Active.gif",
            HtmlEditorEdRuleNImage = HtmlEditorName + ".Ed-Rule-Inactive.gif",
            HtmlEditorEdLinkAImage = HtmlEditorName + ".Ed-Link-Active.gif",
            HtmlEditorEdLinkNImage = HtmlEditorName + ".Ed-Link-Inactive.gif",
            HtmlEditorEdFormatItalicAImage = HtmlEditorName + ".Ed-FormatItalic-Active.gif",
            HtmlEditorEdFormatItalicNImage = HtmlEditorName + ".Ed-FormatItalic-Inactive.gif",
            HtmlEditorEdAlingCenterAImage = HtmlEditorName + ".Ed-AlignCenter-Active.gif",
            HtmlEditorEdAlingCenterNImage = HtmlEditorName + ".Ed-AlignCenter-Inactive.gif",
            HtmlEditorEdAlignJustifyAImage = HtmlEditorName + ".Ed-AlignJustify-Active.gif",
            HtmlEditorEdAlignJustifyNImage = HtmlEditorName + ".Ed-AlignJustify-Inactive.gif",
            HtmlEditorEdAlignLeftAImage = HtmlEditorName + ".Ed-AlignLeft-Active.gif",
            HtmlEditorEdAlignLeftNImage = HtmlEditorName + ".Ed-AlignLeft-Inactive.gif",
            HtmlEditorEdAlignRightAImage = HtmlEditorName + ".Ed-AlignRight-Active.gif",
            HtmlEditorEdAlignRightNImage = HtmlEditorName + ".Ed-AlignRight-Inactive.gif",
            HtmlEditorEdFormatLtrAImage = HtmlEditorName + ".Ed-FormatLtr-Active.gif",
            HtmlEditorEdFormatLtrNImage = HtmlEditorName + ".Ed-FormatLtr-Inactive.gif",
            HtmlEditorEdListNumAImage = HtmlEditorName + ".Ed-ListNum-Active.gif",
            HtmlEditorEdListNumNImage = HtmlEditorName + ".Ed-ListNum-Inactive.gif",
            HtmlEditorEdFormatParagraphAImage = HtmlEditorName + ".Ed-FormatParagraph-Active.gif",
            HtmlEditorEdFormatParagraphNImage = HtmlEditorName + ".Ed-FormatParagraph-Inactive.gif",
            HtmlEditorEdPasteAImage = HtmlEditorName + ".Ed-Paste-Active.gif",
            HtmlEditorEdPasteNImage = HtmlEditorName + ".Ed-Paste-Inactive.gif",
            HtmlEditorEdPasteTextAImage = HtmlEditorName + ".Ed-PasteText-Active.gif",
            HtmlEditorEdPasteTextNImage = HtmlEditorName + ".Ed-PasteText-Inactive.gif",
            HtmlEditorEdPasteWordAImage = HtmlEditorName + ".Ed-PasteWord-Active.gif",
            HtmlEditorEdPasteWordNImage = HtmlEditorName + ".Ed-PasteWord-Inactive.gif",
            HtmlEditorEdPreviewAImage = HtmlEditorName + ".Ed-Preview-Active.gif",
            HtmlEditorEdPreviewNImage = HtmlEditorName + ".Ed-Preview-Inactive.gif",
            HtmlEditorEdRedoAImage = HtmlEditorName + ".Ed-Redo-Active.gif",
            HtmlEditorEdRedoNImage = HtmlEditorName + ".Ed-Redo-Inactive.gif",
            HtmlEditorEdRemoveAlignAImage = HtmlEditorName + ".Ed-AlignRemove-Active.gif",
            HtmlEditorEdRemoveAlignNImage = HtmlEditorName + ".Ed-AlignRemove-Inactive.gif",
            HtmlEditorEdUnlinkAImage = HtmlEditorName + ".Ed-Unlink-Active.gif",
            HtmlEditorEdUnlinkNImage = HtmlEditorName + ".Ed-Unlink-Inactive.gif",
            HtmlEditorEdUnformatAImage = HtmlEditorName + ".Ed-Unformat-Active.gif",
            HtmlEditorEdUnformatNImage = HtmlEditorName + ".Ed-Unformat-Inactive.gif",
            HtmlEditorEdFormatRtlAImage = HtmlEditorName + ".Ed-FormatRtl-Active.gif",
            HtmlEditorEdFormatRtlNImage = HtmlEditorName + ".Ed-FormatRtl-Inactive.gif",
            HtmlEditorEdSelectorAImage = HtmlEditorName + ".Ed-Selector-Active.gif",
            HtmlEditorEdSelectorNImage = HtmlEditorName + ".Ed-Selector-Inactive.gif",
            HtmlEditorEdFormatStrikeAImage = HtmlEditorName + ".Ed-FormatStrike-Active.gif",
            HtmlEditorEdFormatStrikeNImage = HtmlEditorName + ".Ed-FormatStrike-Inactive.gif",
            HtmlEditorEdFormatSubAImage = HtmlEditorName + ".Ed-FormatSub-Active.gif",
            HtmlEditorEdFormatSubNImage = HtmlEditorName + ".Ed-FormatSub-Inactive.gif",
            HtmlEditorEdFormatSupAImage = HtmlEditorName + ".Ed-FormatSup-Active.gif",
            HtmlEditorEdFormatSupNImage = HtmlEditorName + ".Ed-FormatSup-Inactive.gif",
            HtmlEditorEdFormatUnderlineAImage = HtmlEditorName + ".Ed-FormatUnderline-Active.gif",
            HtmlEditorEdFormatUnderlineNImage = HtmlEditorName + ".Ed-FormatUnderline-Inactive.gif",
            HtmlEditorEdUndoAImage = HtmlEditorName + ".Ed-Undo-Active.gif",
            HtmlEditorEdUndoNImage = HtmlEditorName + ".Ed-Undo-Inactive.gif",
            HtmlEditorEd1x1Image = HtmlEditorName + ".Ed-1x1.gif",
            HtmlEditorEdAnchorImage = HtmlEditorName + ".Ed-Anchor.gif",
            HtmlEditorEdFlashImage = HtmlEditorName + ".Ed-Flash.gif",
            HtmlEditorEdMediaImage = HtmlEditorName + ".Ed-Media.gif",
            HtmlEditorEdPlaceHolderImage = HtmlEditorName + ".Ed-Placeholder.gif",
            HtmlEditorExtenderButtonsImage = HtmlEditorName + "Extender.Buttons.png",

            BalloonPopupCloudGifSprite = BalloonPopupName + ".CloudSprite.gif",
            BalloonPopupCloudPngSprite = BalloonPopupName + ".CloudSprite.png",
            BalloonPopupRectangleGifSprite = BalloonPopupName + ".RectangleSprite.gif",
            BalloonPopupRectanglePngSprite = BalloonPopupName + ".RectangleSprite.png",
            CalendarArrowLeftImage = CalendarName + ".Arrow-Left.gif",
            CalendarArrowRightImage = CalendarName + ".Arrow-Right.gif",
            ComboBoxArrowDownImage = ComboBoxName + ".Arrow-Down.gif",
            DropDownDropArrowImage = DropDownName + ".DropArrow.gif",
            GravatarAnonymousImage = GravatarName + ".Anonymous.jpg",
            GravatarGImage = GravatarName + ".G.jpg",
            GravatarPGImage = GravatarName + ".PG.jpg",
            GravatarRImage = GravatarName + ".R.jpg",
            GravatarXImage = GravatarName + ".X.jpg",
            MultiHandleSliderHHandleImage = MultiHandleSliderName + ".Handle-Horizontal.gif",
            MultiHandleSliderHHandleDownImage = MultiHandleSliderName + ".HandleDown-Horizontal.gif",
            MultiHandleSliderHHandleHoverImage = MultiHandleSliderName + ".HandleHover-Horizontal.gif",
            MultiHandleSliderHRailImage = MultiHandleSliderName + ".Rail-Horizontal.gif",
            MultiHandleSliderHRailOuterImage = MultiHandleSliderName + ".RailOuter-Horizontal.gif",
            MultiHandleSliderVHandleImage = MultiHandleSliderName + ".Handle-Vertical.gif",
            MultiHandleSliderVHandleDownImage = MultiHandleSliderName + ".HandleDown-Vertical.gif",
            MultiHandleSliderVHandleHoverImage = MultiHandleSliderName + ".HandleHover-Vertical.gif",
            MultiHandleSliderVRailImage = MultiHandleSliderName + ".Rail-Vertical.gif",
            MultiHandleSliderVRailOuterImage = MultiHandleSliderName + ".RailOuter-Vertical.gif",
            SeadragonFullpageGrouphoverImage = SeadragonName + ".Fullscreen-Grouphover.png",
            SeadragonFullpageHoverImage = SeadragonName + ".Fullscreen-Hover.png",
            SeadragonFullpagePressedImage = SeadragonName + ".Fullscreen-Pressed.png",
            SeadragonFullpageRestImage = SeadragonName + ".Fullscreen-Rest.png",
            SeadragonHomeGrouphoverImage = SeadragonName + ".Home-Grouphover.png",
            SeadragonHomeHoverImage = SeadragonName + ".Home-Hover.png",
            SeadragonHomePressedImage = SeadragonName + ".Home-Pressed.png",
            SeadragonHomeRestImage = SeadragonName + ".Home-Rest.png",
            SeadragonZoominGrouphoverImage = SeadragonName + ".ZoomIn-Grouphover.png",
            SeadragonZoominHoverImage = SeadragonName + ".ZoomIn-Hover.png",
            SeadragonZoominPressedImage = SeadragonName + ".ZoomIn-Pressed.png",
            SeadragonZoominRestImage = SeadragonName + ".ZoomIn-Rest.png",
            SeadragonZoomoutGrouphoverImage = SeadragonName + ".ZoomOut-Grouphover.png",
            SeadragonZoomoutHoverImage = SeadragonName + ".ZoomOut-Hover.png",
            SeadragonZoomoutPressedImage = SeadragonName + ".ZoomOut-Pressed.png",
            SeadragonZoomoutRestImage = SeadragonName + ".ZoomOut-Rest.png",
            SliderVerticalRailImage = SliderName + ".Rail-Vertical.gif",
            SliderHorizontalRailImage = SliderName + ".Rail-Horizontal.gif",
            SliderVerticalHandleImage = SliderName + ".Handle-Vertical.gif",
            SliderHorizontalHandleImage = SliderName + ".Handle-Horizontal.gif",
            TabsImage = TabsName + ".Background.gif",
            TabsActiveLeftVerticalleftImage = TabsName + ".ActiveLeft-VerticalLeft.gif",
            TabsActiveLeftVerticalrightImage = TabsName + ".ActiveLeft-VerticalRight.gif",
            TabsActiveLeftImage = TabsName + ".ActiveLeft.gif",
            TabsActiveRightVerticallefImage = TabsName + ".ActiveRight-VerticalLeft.gif",
            TabsActiveRightVerticalrightImage = TabsName + ".ActiveRight-VerticalRight.gif",
            TabsActiveRightImage = TabsName + ".ActiveRight.gif",
            TabsActiveVerticalleftImage = TabsName + ".Active-VerticalLeft.gif",
            TabsActiveVerticalrightImage = TabsName + ".Active-VerticalRight.gif",
            TabsActiveImage = TabsName + ".Active.gif",
            TabsBottomActiveLeftImage = TabsName + ".Bottom-ActiveLeft.gif",
            TabsBottomActiveRightImage = TabsName + ".Bottom-ActiveRight.gif",
            TabsBottomActiveImage = TabsName + ".Bottom-Active.gif",
            TabsBottomHoverLeftImage = TabsName + ".Bottom-HoverLeft.gif",
            TabsBottomHoverRightImage = TabsName + ".Bottom-HoverRight.gif",
            TabsBottomHoverImage = TabsName + ".Bottom-Hover.gif",
            TabsBottomLeftImage = TabsName + ".Bottom-Left.gif",
            TabsBottomRightImage = TabsName + ".Bottom-Right.gif",
            TabsBottomImage = TabsName + ".Bottom.gif",
            TabsHoverLeftVerticalleftImage = TabsName + ".HoverLeft-VerticalLeft.gif",
            TabsHoverLeftVerticalrightImage = TabsName + ".HoverLeft-VerticalRight.gif",
            TabsHoverLeftImage = TabsName + ".HoverLeft.gif",
            TabsHoverRightVerticalleftImage = TabsName + ".HoverRight-VerticalLeft.gif",
            TabsHoverRightVerticalrightImage = TabsName + ".HoverRight-VerticalRight.gif",
            TabsHoverRightImage = TabsName + ".HoverRight.gif",
            TabsHoverVerticalleftImage = TabsName + ".Hover-VerticalLeft.gif",
            TabsHoverVerticalrightImage = TabsName + ".Hover-VerticalRight.gif",
            TabsHoverImage = TabsName + ".Hover.gif",
            TabsLeftVerticalleftImage = TabsName + ".Left-VerticalLeft.gif",
            TabsLeftVerticalrightImage = TabsName + ".Left-VerticalRight.gif",
            TabsLeftImage = TabsName + ".Left.gif",
            TabsLineImage = TabsName + ".Line.gif",
            TabsRightVerticalleftImage = TabsName + ".Right-VerticalLeft.gif",
            TabsRightVerticalrightImage = TabsName + ".Right-VerticalRight.gif",
            TabsRightImage = TabsName + ".Right.gif",
            TabsVerticalleftImage = TabsName + ".VerticalLeft.gif",
            TabsVerticalrightImage = TabsName + ".VerticalRight.gif",
            Twitter24Image = TwitterName + ".24.png",
            Twitter32Image = TwitterName + ".32.png",
            ValidatorCalloutAlertLargeImage = ValidatorCalloutName + ".Alert-Large.gif",
            ValidatorCalloutAlertSmallImage = ValidatorCalloutName + ".Alert-Small.gif",
            ValidatorCalloutCloseImage = ValidatorCalloutName + ".Close.gif";
    }

}
