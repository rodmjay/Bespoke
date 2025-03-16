import{a as ze}from"./chunk-UKFDZ5NH.js";import{a as $e}from"./chunk-PAEO5PSF.js";import{a as Le,b as Fe}from"./chunk-AGR62YLL.js";import{a as Se}from"./chunk-MEZEMTYB.js";import{a as Te}from"./chunk-SMJIQ4E4.js";import{a as ke}from"./chunk-YUUY53IN.js";import{a as Me}from"./chunk-5ITMLF3G.js";import{c as Ve,f as Ee,g as Ae}from"./chunk-TI2YGS5M.js";import{Aa as ve,Ba as Ie,Da as Oe,T as ye,W as A,X as M,Y as Z,aa as W,ia as xe,pa as be,sa as Ce,t as Q,ta as J,u as k,ua as we}from"./chunk-ZHGKNXMS.js";import{$b as K,Ab as v,Bb as I,Cb as O,Db as T,Fb as w,Gb as a,Jc as de,Kb as b,Kc as me,Lb as S,Lc as _e,Mb as g,Nb as f,Oc as he,P as X,Pa as s,Pc as ge,Q as Y,Qb as G,R as ee,Rb as D,Sb as U,Tb as P,Ua as B,Uc as fe,Vb as pe,W as q,Wb as re,Xb as se,Yb as ce,Zb as N,_b as V,aa as u,ab as ie,ba as d,bb as ne,ea as te,eb as le,gb as c,ka as C,la as oe,mc as $,nb as y,ob as r,pa as L,pb as ae,rb as H,sb as F,sc as _,tc as E,vc as j,wc as ue,xb as m,yb as h,zb as z}from"./chunk-DKCBYRU7.js";var qe=["item"],Be=["empty"],He=["header"],Ge=["footer"],Ue=["selecteditem"],Pe=["group"],Ne=["loader"],je=["removeicon"],Ze=["loadingicon"],We=["clearicon"],Je=["dropdownicon"],Xe=["container"],Ye=["focusInput"],et=["multiIn"],tt=["multiContainer"],ot=["ddBtn"],it=["items"],nt=["scroller"],lt=["overlay"],at=t=>({"p-autocomplete-chip-item":!0,"p-focus":t}),Ke=t=>({$implicit:t}),pt=()=>({class:"p-autocomplete-chip-icon"}),R=t=>({height:t}),Qe=(t,l)=>({$implicit:t,options:l}),rt=t=>({options:t}),st=()=>({}),ct=(t,l)=>({$implicit:t,index:l});function ut(t,l){if(t&1){let e=T();m(0,"input",19,3),w("input",function(i){u(e);let n=a();return d(n.onInput(i))})("keydown",function(i){u(e);let n=a();return d(n.onKeyDown(i))})("change",function(i){u(e);let n=a();return d(n.onInputChange(i))})("focus",function(i){u(e);let n=a();return d(n.onInputFocus(i))})("blur",function(i){u(e);let n=a();return d(n.onInputBlur(i))})("paste",function(i){u(e);let n=a();return d(n.onInputPaste(i))})("keyup",function(i){u(e);let n=a();return d(n.onInputKeyUp(i))}),h()}if(t&2){let e,o=a();F(o.inputStyleClass),r("pAutoFocus",o.autofocus)("ngClass","p-autocomplete-input")("ngStyle",o.inputStyle)("type",o.type)("variant",o.variant)("autocomplete",o.autocomplete)("required",o.required)("name",o.name)("pSize",o.size)("tabindex",o.disabled?-1:o.tabindex)("readonly",o.readonly)("disabled",o.disabled)("fluid",o.hasFluid),y("value",o.inputValue())("id",o.inputId)("placeholder",o.placeholder)("maxlength",o.maxlength)("aria-label",o.ariaLabel)("aria-labelledby",o.ariaLabelledBy)("aria-required",o.required)("aria-expanded",(e=o.overlayVisible)!==null&&e!==void 0?e:!1)("aria-controls",o.overlayVisible?o.id+"_list":null)("aria-activedescendant",o.focused?o.focusedOptionId:void 0)}}function dt(t,l){if(t&1){let e=T();m(0,"TimesIcon",22),w("click",function(){u(e);let i=a(2);return d(i.clear())}),h()}t&2&&(r("styleClass","p-autocomplete-clear-icon"),y("aria-hidden",!0))}function mt(t,l){}function _t(t,l){t&1&&c(0,mt,0,0,"ng-template")}function ht(t,l){if(t&1){let e=T();m(0,"span",23),w("click",function(){u(e);let i=a(2);return d(i.clear())}),c(1,_t,1,0,null,24),h()}if(t&2){let e=a(2);y("aria-hidden",!0),s(),r("ngTemplateOutlet",e.clearIconTemplate||e._clearIconTemplate)}}function gt(t,l){if(t&1&&(v(0),c(1,dt,1,2,"TimesIcon",20)(2,ht,2,2,"span",21),I()),t&2){let e=a();s(),r("ngIf",!e.clearIconTemplate&&!e._clearIconTemplate),s(),r("ngIf",e.clearIconTemplate||e._clearIconTemplate)}}function ft(t,l){t&1&&O(0)}function yt(t,l){if(t&1){let e=T();m(0,"span",33),w("click",function(i){u(e);let n=a(3).index,p=a(2);return d(p.readonly?"":p.removeOption(i,n))}),z(1,"TimesCircleIcon",34),h()}t&2&&(s(),r("styleClass","p-autocomplete-chip-icon"),y("aria-hidden",!0))}function xt(t,l){t&1&&(v(0),c(1,yt,2,2,"ng-template",null,6,$),I())}function bt(t,l){if(t&1&&(m(0,"p-chip",32),c(1,xt,3,0,"ng-container",15),h()),t&2){let e=a().$implicit,o=a(2);r("label",o.getOptionLabel(e))("removable",!0),s(),r("ngIf",!o.removeIconTemplate&&!o._removeIconTemplate)}}function Ct(t,l){}function wt(t,l){t&1&&c(0,Ct,0,0,"ng-template")}function vt(t,l){if(t&1&&(m(0,"span"),c(1,wt,1,0,null,30),h()),t&2){let e=a(3);y("aria-hidden",!0),s(),r("ngTemplateOutlet",e.removeIconTemplate||e._removeIconTemplate)("ngTemplateOutletContext",N(3,pt))}}function It(t,l){if(t&1&&(m(0,"li",29,5),c(2,ft,1,0,"ng-container",30)(3,bt,2,3,"p-chip",31)(4,vt,2,4,"span",15),h()),t&2){let e=l.$implicit,o=l.index,i=a(2);r("ngClass",V(10,at,i.focusedMultipleOptionIndex()===o)),y("id",i.id+"_multiple_option_"+o)("aria-label",i.getOptionLabel(e))("aria-setsize",i.modelValue().length)("aria-posinset",o+1)("aria-selected",!0),s(2),r("ngTemplateOutlet",i.selectedItemTemplate||i._selectedItemTemplate)("ngTemplateOutletContext",V(12,Ke,e)),s(),r("ngIf",!i.selectedItemTemplate&&!i._selectedItemTemplate),s(),r("ngIf",i.removeIconTemplate||i._removeIconTemplate)}}function Ot(t,l){if(t&1){let e=T();m(0,"ul",25,4),w("focus",function(i){u(e);let n=a();return d(n.onMultipleContainerFocus(i))})("blur",function(i){u(e);let n=a();return d(n.onMultipleContainerBlur(i))})("keydown",function(i){u(e);let n=a();return d(n.onMultipleContainerKeyDown(i))}),c(2,It,5,14,"li",26),m(3,"li",27)(4,"input",28,3),w("input",function(i){u(e);let n=a();return d(n.onInput(i))})("keydown",function(i){u(e);let n=a();return d(n.onKeyDown(i))})("change",function(i){u(e);let n=a();return d(n.onInputChange(i))})("focus",function(i){u(e);let n=a();return d(n.onInputFocus(i))})("blur",function(i){u(e);let n=a();return d(n.onInputBlur(i))})("paste",function(i){u(e);let n=a();return d(n.onInputPaste(i))})("keyup",function(i){u(e);let n=a();return d(n.onInputKeyUp(i))}),h()()()}if(t&2){let e,o=a();r("ngClass",o.inputMultipleClass)("tabindex",-1),y("aria-orientation","horizontal")("aria-activedescendant",o.focused?o.focusedMultipleOptionId:void 0),s(2),r("ngForOf",o.modelValue()),s(2),F(o.inputStyleClass),r("pAutoFocus",o.autofocus)("ngClass",o.inputClass)("ngStyle",o.inputStyle)("autocomplete",o.autocomplete)("required",o.required)("tabindex",o.disabled?-1:o.tabindex)("readonly",o.readonly)("disabled",o.disabled),y("type",o.type)("id",o.inputId)("name",o.name)("placeholder",o.filled?null:o.placeholder)("maxlength",o.maxlength)("aria-label",o.ariaLabel)("aria-labelledby",o.ariaLabelledBy)("aria-required",o.required)("aria-expanded",(e=o.overlayVisible)!==null&&e!==void 0?e:!1)("aria-controls",o.overlayVisible?o.id+"_list":null)("aria-activedescendant",o.focused?o.focusedOptionId:void 0)}}function Tt(t,l){t&1&&z(0,"SpinnerIcon",37),t&2&&(r("styleClass","p-autocomplete-loader")("spin",!0),y("aria-hidden",!0))}function St(t,l){}function Vt(t,l){t&1&&c(0,St,0,0,"ng-template")}function kt(t,l){if(t&1&&(m(0,"span",38),c(1,Vt,1,0,null,24),h()),t&2){let e=a(2);y("aria-hidden",!0),s(),r("ngTemplateOutlet",e.loadingIconTemplate||e._loadingIconTemplate)}}function Et(t,l){if(t&1&&(v(0),c(1,Tt,1,3,"SpinnerIcon",35)(2,kt,2,2,"span",36),I()),t&2){let e=a();s(),r("ngIf",!e.loadingIconTemplate&&!e._loadingIconTemplate),s(),r("ngIf",e.loadingIconTemplate||e._loadingIconTemplate)}}function Mt(t,l){if(t&1&&z(0,"span",41),t&2){let e=a(2);r("ngClass",e.dropdownIcon),y("aria-hidden",!0)}}function $t(t,l){t&1&&z(0,"ChevronDownIcon")}function At(t,l){}function Lt(t,l){t&1&&c(0,At,0,0,"ng-template")}function Ft(t,l){if(t&1&&(v(0),c(1,$t,1,0,"ChevronDownIcon",15)(2,Lt,1,0,null,24),I()),t&2){let e=a(2);s(),r("ngIf",!e.dropdownIconTemplate&&!e._dropdownIconTemplate),s(),r("ngTemplateOutlet",e.dropdownIconTemplate||e._dropdownIconTemplate)}}function zt(t,l){if(t&1){let e=T();m(0,"button",39,7),w("click",function(i){u(e);let n=a();return d(n.handleDropdownClick(i))}),c(2,Mt,1,2,"span",40)(3,Ft,3,2,"ng-container",15),h()}if(t&2){let e=a();r("disabled",e.disabled),y("aria-label",e.dropdownAriaLabel)("tabindex",e.tabindex),s(2),r("ngIf",e.dropdownIcon),s(),r("ngIf",!e.dropdownIcon)}}function Dt(t,l){t&1&&O(0)}function Kt(t,l){t&1&&O(0)}function Qt(t,l){if(t&1&&c(0,Kt,1,0,"ng-container",30),t&2){let e=l.$implicit,o=l.options;a(2);let i=G(6);r("ngTemplateOutlet",i)("ngTemplateOutletContext",K(2,Qe,e,o))}}function Rt(t,l){t&1&&O(0)}function qt(t,l){if(t&1&&c(0,Rt,1,0,"ng-container",30),t&2){let e=l.options,o=a(4);r("ngTemplateOutlet",o.loaderTemplate||o._loaderTemplate)("ngTemplateOutletContext",V(2,rt,e))}}function Bt(t,l){t&1&&(v(0),c(1,qt,1,4,"ng-template",null,10,$),I())}function Ht(t,l){if(t&1){let e=T();m(0,"p-scroller",46,9),w("onLazyLoad",function(i){u(e);let n=a(2);return d(n.onLazyLoad.emit(i))}),c(2,Qt,1,5,"ng-template",null,2,$)(4,Bt,3,0,"ng-container",15),h()}if(t&2){let e=a(2);H(V(8,R,e.scrollHeight)),r("items",e.visibleOptions())("itemSize",e.virtualScrollItemSize||e._itemSize)("autoSize",!0)("lazy",e.lazy)("options",e.virtualScrollOptions),s(4),r("ngIf",e.loaderTemplate||e._loaderTemplate)}}function Gt(t,l){t&1&&O(0)}function Ut(t,l){if(t&1&&(v(0),c(1,Gt,1,0,"ng-container",30),I()),t&2){a();let e=G(6),o=a();s(),r("ngTemplateOutlet",e)("ngTemplateOutletContext",K(3,Qe,o.visibleOptions(),N(2,st)))}}function Pt(t,l){if(t&1&&(m(0,"span"),D(1),h()),t&2){let e=a(2).$implicit,o=a(3);s(),U(o.getOptionGroupLabel(e.optionGroup))}}function Nt(t,l){t&1&&O(0)}function jt(t,l){if(t&1&&(v(0),m(1,"li",50),c(2,Pt,2,1,"span",15)(3,Nt,1,0,"ng-container",30),h(),I()),t&2){let e=a(),o=e.$implicit,i=e.index,n=a().options,p=a(2);s(),r("ngStyle",V(5,R,n.itemSize+"px")),y("id",p.id+"_"+p.getOptionIndex(i,n)),s(),r("ngIf",!p.groupTemplate),s(),r("ngTemplateOutlet",p.groupTemplate)("ngTemplateOutletContext",V(7,Ke,o.optionGroup))}}function Zt(t,l){if(t&1&&(m(0,"span"),D(1),h()),t&2){let e=a(2).$implicit,o=a(3);s(),U(o.getOptionLabel(e))}}function Wt(t,l){t&1&&O(0)}function Jt(t,l){if(t&1){let e=T();v(0),m(1,"li",51),w("click",function(i){u(e);let n=a().$implicit,p=a(3);return d(p.onOptionSelect(i,n))})("mouseenter",function(i){u(e);let n=a().index,p=a().options,x=a(2);return d(x.onOptionMouseEnter(i,x.getOptionIndex(n,p)))}),c(2,Zt,2,1,"span",15)(3,Wt,1,0,"ng-container",30),h(),I()}if(t&2){let e=a(),o=e.$implicit,i=e.index,n=a().options,p=a(2);s(),r("ngStyle",V(12,R,n.itemSize+"px"))("ngClass",p.optionClass(o,i,n)),y("id",p.id+"_"+p.getOptionIndex(i,n))("aria-label",p.getOptionLabel(o))("aria-selected",p.isSelected(o))("aria-disabled",p.isOptionDisabled(o))("data-p-focused",p.focusedOptionIndex()===p.getOptionIndex(i,n))("aria-setsize",p.ariaSetSize)("aria-posinset",p.getAriaPosInset(p.getOptionIndex(i,n))),s(),r("ngIf",!p.itemTemplate&&!p._itemTemplate),s(),r("ngTemplateOutlet",p.itemTemplate||p._itemTemplate)("ngTemplateOutletContext",K(14,ct,o,n.getOptions?n.getOptions(i):i))}}function Xt(t,l){if(t&1&&c(0,jt,4,9,"ng-container",15)(1,Jt,4,17,"ng-container",15),t&2){let e=l.$implicit,o=a(3);r("ngIf",o.isOptionGroup(e)),s(),r("ngIf",!o.isOptionGroup(e))}}function Yt(t,l){if(t&1&&(v(0),D(1),I()),t&2){let e=a(4);s(),P(" ",e.searchResultMessageText," ")}}function eo(t,l){t&1&&O(0,null,12)}function to(t,l){if(t&1&&(m(0,"li",52),c(1,Yt,2,1,"ng-container",53)(2,eo,2,0,"ng-container",24),h()),t&2){let e=a().options,o=a(2);r("ngStyle",V(4,R,e.itemSize+"px")),s(),r("ngIf",!o.emptyTemplate&&!o._emptyTemplate)("ngIfElse",o.empty),s(),r("ngTemplateOutlet",o.emptyTemplate||o._emptyTemplate)}}function oo(t,l){if(t&1&&(m(0,"ul",47,11),c(2,Xt,2,2,"ng-template",48)(3,to,3,6,"li",49),h()),t&2){let e=l.$implicit,o=l.options,i=a(2);H(o.contentStyle),r("ngClass",o.contentStyleClass),y("id",i.id+"_list")("aria-label",i.listLabel),s(2),r("ngForOf",e),s(),r("ngIf",!e||e&&e.length===0&&i.showEmptyMessage)}}function io(t,l){t&1&&O(0)}function no(t,l){if(t&1&&(m(0,"div",42),c(1,Dt,1,0,"ng-container",24),m(2,"div",43),c(3,Ht,5,10,"p-scroller",44)(4,Ut,2,6,"ng-container",15),h(),c(5,oo,4,7,"ng-template",null,8,$)(7,io,1,0,"ng-container",24),h(),m(8,"span",45),D(9),h()),t&2){let e=a();F(e.panelStyleClass),r("ngClass",e.panelClass)("ngStyle",e.panelStyle),s(),r("ngTemplateOutlet",e.headerTemplate||e._headerTemplate),s(),ae("max-height",e.virtualScroll?"auto":e.scrollHeight),s(),r("ngIf",e.virtualScroll),s(),r("ngIf",!e.virtualScroll),s(3),r("ngTemplateOutlet",e.footerTemplate||e._footerTemplate),s(2),P(" ",e.selectedMessageText," ")}}var lo=({dt:t})=>`
.p-autocomplete {
    display: inline-flex;
}

.p-autocomplete-loader {
    position: absolute;
    top: 50%;
    margin-top: -0.5rem;
    inset-inline-end: ${t("autocomplete.padding.x")};
}

.p-autocomplete:has(.p-autocomplete-dropdown) .p-autocomplete-loader {
    inset-inline-end: calc(${t("autocomplete.dropdown.width")} + ${t("autocomplete.padding.x")});
}

.p-autocomplete:has(.p-autocomplete-dropdown) .p-autocomplete-input {
    flex: 1 1 auto;
    width: 1%;
}

.p-autocomplete:has(.p-autocomplete-dropdown) .p-autocomplete-input,
.p-autocomplete:has(.p-autocomplete-dropdown) .p-autocomplete-input-multiple {
    border-start-end-radius: 0;
    border-end-end-radius: 0;
}

.p-autocomplete-dropdown {
    cursor: pointer;
    display: inline-flex;
    user-select: none;
    align-items: center;
    justify-content: center;
    overflow: hidden;
    position: relative;
    width: ${t("autocomplete.dropdown.width")};
    border-start-end-radius: ${t("autocomplete.dropdown.border.radius")};
    border-end-end-radius: ${t("autocomplete.dropdown.border.radius")};
    background: ${t("autocomplete.dropdown.background")};
    border: 1px solid ${t("autocomplete.dropdown.border.color")};
    border-inline-start: 0 none;
    color: ${t("autocomplete.dropdown.color")};
    transition: background ${t("autocomplete.transition.duration")}, color ${t("autocomplete.transition.duration")}, border-color ${t("autocomplete.transition.duration")}, outline-color ${t("autocomplete.transition.duration")}, box-shadow ${t("autocomplete.transition.duration")};
    outline-color: transparent;
}

.p-autocomplete-dropdown:not(:disabled):hover {
    background: ${t("autocomplete.dropdown.hover.background")};
    border-color: ${t("autocomplete.dropdown.hover.border.color")};
    color: ${t("autocomplete.dropdown.hover.color")};
}

.p-autocomplete-dropdown:not(:disabled):active {
    background: ${t("autocomplete.dropdown.active.background")};
    border-color: ${t("autocomplete.dropdown.active.border.color")};
    color: ${t("autocomplete.dropdown.active.color")};
}

.p-autocomplete-dropdown:focus-visible {
    box-shadow: ${t("autocomplete.dropdown.focus.ring.shadow")};
    outline: ${t("autocomplete.dropdown.focus.ring.width")} ${t("autocomplete.dropdown.focus.ring.style")} ${t("autocomplete.dropdown.focus.ring.color")};
    outline-offset: ${t("autocomplete.dropdown.focus.ring.offset")};
}

.p-autocomplete .p-autocomplete-overlay {
    min-width: 100%;
}

.p-autocomplete-overlay {
    background: ${t("autocomplete.overlay.background")};
    color: ${t("autocomplete.overlay.color")};
    border: 1px solid ${t("autocomplete.overlay.border.color")};
    border-radius: ${t("autocomplete.overlay.border.radius")};
    box-shadow: ${t("autocomplete.overlay.shadow")};
}

.p-autocomplete-list-container {
    overflow: auto;
}

.p-autocomplete-list {
    margin: 0;
    list-style-type: none;
    display: flex;
    flex-direction: column;
    gap: ${t("autocomplete.list.gap")};
    padding: ${t("autocomplete.list.padding")};
}

.p-autocomplete-option {
    cursor: pointer;
    white-space: nowrap;
    position: relative;
    overflow: hidden;
    display: flex;
    align-items: center;
    padding: ${t("autocomplete.option.padding")};
    border: 0 none;
    color: ${t("autocomplete.option.color")};
    background: transparent;
    transition: background ${t("autocomplete.transition.duration")}, color ${t("autocomplete.transition.duration")}, border-color ${t("autocomplete.transition.duration")};
    border-radius: ${t("autocomplete.option.border.radius")};
}

.p-autocomplete-option:not(.p-autocomplete-option-selected):not(.p-disabled).p-focus {
    background: ${t("autocomplete.option.focus.background")};
    color: ${t("autocomplete.option.focus.color")};
}

.p-autocomplete-option-selected {
    background: ${t("autocomplete.option.selected.background")};
    color: ${t("autocomplete.option.selected.color")};
}

.p-autocomplete-option-selected.p-focus {
    background: ${t("autocomplete.option.selected.focus.background")};
    color: ${t("autocomplete.option.selected.focus.color")};
}

.p-autocomplete-option-group {
    margin: 0;
    padding: ${t("autocomplete.option.group.padding")};
    color: ${t("autocomplete.option.group.color")};
    background: ${t("autocomplete.option.group.background")};
    font-weight: ${t("autocomplete.option.group.font.weight")};
}

.p-autocomplete-input-multiple {
    margin: 0;
    list-style-type: none;
    cursor: text;
    overflow: hidden;
    display: flex;
    align-items: center;
    flex-wrap: wrap;
    padding: calc(${t("autocomplete.padding.y")} / 2) ${t("autocomplete.padding.x")};
    gap: calc(${t("autocomplete.padding.y")} / 2);
    color: ${t("autocomplete.color")};
    background: ${t("autocomplete.background")};
    border: 1px solid ${t("autocomplete.border.color")};
    border-radius: ${t("autocomplete.border.radius")};
    width: 100%;
    transition: background ${t("autocomplete.transition.duration")}, color ${t("autocomplete.transition.duration")}, border-color ${t("autocomplete.transition.duration")}, outline-color ${t("autocomplete.transition.duration")}, box-shadow ${t("autocomplete.transition.duration")};
    outline-color: transparent;
    box-shadow: ${t("autocomplete.shadow")};
}

.p-autocomplete:not(.p-disabled):hover .p-autocomplete-input-multiple {
    border-color: ${t("autocomplete.hover.border.color")};
}

.p-autocomplete:not(.p-disabled).p-focus .p-autocomplete-input-multiple {
    border-color: ${t("autocomplete.focus.border.color")};
    box-shadow: ${t("autocomplete.focus.ring.shadow")};
    outline: ${t("autocomplete.focus.ring.width")} ${t("autocomplete.focus.ring.style")} ${t("autocomplete.focus.ring.color")};
    outline-offset: ${t("autocomplete.focus.ring.offset")};
}

.p-autocomplete.p-invalid .p-autocomplete-input-multiple {
    border-color: ${t("autocomplete.invalid.border.color")};
}

.p-variant-filled.p-autocomplete-input-multiple {
    background: ${t("autocomplete.filled.background")};
}

.p-autocomplete:not(.p-disabled):hover .p-variant-filled.p-autocomplete-input-multiple {
    background: ${t("autocomplete.filled.hover.background")};
}

.p-autocomplete:not(.p-disabled).p-focus .p-variant-filled.p-autocomplete-input-multiple  {
    background: ${t("autocomplete.filled.focus.background")};
}

.p-autocomplete.p-disabled .p-autocomplete-input-multiple {
    opacity: 1;
    background: ${t("autocomplete.disabled.background")};
    color: ${t("autocomplete.disabled.color")};
}

.p-autocomplete-chip.p-chip {
    padding-block-start: calc(${t("autocomplete.padding.y")} / 2);
    padding-block-end: calc(${t("autocomplete.padding.y")} / 2);
    border-radius: ${t("autocomplete.chip.border.radius")};
}

.p-autocomplete-input-multiple:has(.p-autocomplete-chip) {
    padding-inline-start: calc(${t("autocomplete.padding.y")} / 2);
    padding-inline-end: calc(${t("autocomplete.padding.y")} / 2);
}

.p-autocomplete-chip-item.p-focus .p-autocomplete-chip {
    background: ${t("autocomplete.chip.focus.background")};
    color: ${t("autocomplete.chip.focus.color")};
}

.p-autocomplete-input-chip {
    flex: 1 1 auto;
    display: inline-flex;
    padding-block-start: calc(${t("autocomplete.padding.y")} / 2);
    padding-block-end: calc(${t("autocomplete.padding.y")} / 2);
}

.p-autocomplete-input-chip input {
    border: 0 none;
    outline: 0 none;
    background: transparent;
    margin: 0;
    padding: 0;
    box-shadow: none;
    border-radius: 0;
    width: 100%;
    font-family: inherit;
    font-feature-settings: inherit;
    font-size: 1rem;
    color: inherit;
}

.p-autocomplete-input-chip input::placeholder {
    color: ${t("autocomplete.placeholder.color")};
}

.p-autocomplete-empty-message {
    padding: ${t("autocomplete.empty.message.padding")};
}

.p-autocomplete-fluid {
    display: flex;
}

.p-autocomplete-fluid:has(.p-autocomplete-dropdown) .p-autocomplete-input {
    width: 1%;
}

.p-autocomplete:has(.p-inputtext-sm) .p-autocomplete-dropdown {
    width: ${t("autocomplete.dropdown.sm.width")};
}

.p-autocomplete:has(.p-inputtext-sm) .p-autocomplete-dropdown .p-icon {
    font-size: ${t("form.field.sm.font.size")};
    width: ${t("form.field.sm.font.size")};
    height: ${t("form.field.sm.font.size")};
}

.p-autocomplete:has(.p-inputtext-lg) .p-autocomplete-dropdown {
    width: ${t("autocomplete.dropdown.lg.width")};
}

.p-autocomplete:has(.p-inputtext-lg) .p-autocomplete-dropdown .p-icon {
    font-size: ${t("form.field.lg.font.size")};
    width: ${t("form.field.lg.font.size")};
    height: ${t("form.field.lg.font.size")};
}

.p-autocomplete-clear-icon {
    position: absolute;
    top: 50%;
    margin-top: -0.5rem;
    cursor: pointer;
    right: ${t("autocomplete.padding.x")};
    color: ${t("autocomplete.dropdown.color")};
}

.p-autocomplete:has(.p-autocomplete-dropdown) .p-autocomplete-clear-icon {
    right: calc(${t("autocomplete.padding.x")} + ${t("autocomplete.dropdown.width")});
}

.p-autocomplete.ng-invalid.ng-dirty .p-autocomplete-input,
.p-autocomplete.ng-invalid.ng-dirty .p-autocomplete-input-multiple {
    border-color: ${t("autocomplete.invalid.border.color")};
}

.p-autocomplete.ng-invalid.ng-dirty .p-autocomplete-input:enabled:focus,
.p-autocomplete.ng-invalid.ng-dirty:not(.p-disabled).p-focus .p-autocomplete-input-multiple {
    border-color: ${t("autocomplete.focus.border.color")};
}

.p-autocomplete.ng-invalid.ng-dirty .p-autocomplete-input-chip input::placeholder {
    color: ${t("autocomplete.invalid.placeholder.color")};
}

.p-autocomplete.ng-invalid.ng-dirty .p-autocomplete-input::placeholder {
    color: ${t("autocomplete.invalid.placeholder.color")};
}`,ao={root:{position:"relative"}},po={root:({instance:t})=>({"p-autocomplete p-component p-inputwrapper":!0,"p-disabled":t.disabled,"p-focus":t.focused,"p-inputwrapper-filled":t.filled,"p-inputwrapper-focus":t.focused&&!t.disabled||t.autofocus||t.overlayVisible,"p-autocomplete-open":t.overlayVisible,"p-autocomplete-clearable":t.showClear&&!t.disabled,"p-autocomplete-fluid":t.hasFluid}),pcInput:"p-autocomplete-input",inputMultiple:({instance:t})=>({"p-autocomplete-input-multiple":!0,"p-variant-filled":(t.variant??(t.config.inputStyle()||t.config.inputVariant()))==="filled"}),chipItem:({instance:t,i:l})=>["p-autocomplete-chip-item",{"p-focus":t.focusedMultipleOptionIndex===l}],pcChip:"p-autocomplete-chip",chipIcon:"p-autocomplete-chip-icon",inputChip:"p-autocomplete-input-chip",loader:"p-autocomplete-loader",dropdown:"p-autocomplete-dropdown",overlay:"p-autocomplete-overlay p-component",list:"p-autocomplete-list",optionGroup:"p-autocomplete-option-group",option:({instance:t,option:l,i:e,getItemOptions:o})=>({"p-autocomplete-option":!0,"p-autocomplete-option-selected":t.isSelected(l),"p-focus":t.focusedOptionIndex===t.getOptionIndex(e,o),"p-disabled":t.isOptionDisabled(l)}),emptyMessage:"p-autocomplete-empty-message"},De=(()=>{class t extends ve{name="autocomplete";theme=lo;classes=po;inlineStyles=ao;static \u0275fac=(()=>{let e;return function(i){return(e||(e=te(t)))(i||t)}})();static \u0275prov=Y({token:t,factory:t.\u0275fac})}return t})();var ro={provide:Te,useExisting:X(()=>Re),multi:!0},Re=(()=>{class t extends Oe{overlayService;zone;minLength=1;delay=300;style;panelStyle;styleClass;panelStyleClass;inputStyle;inputId;inputStyleClass;placeholder;readonly;disabled;scrollHeight="200px";lazy=!1;virtualScroll;virtualScrollItemSize;virtualScrollOptions;maxlength;name;required;size;appendTo;autoHighlight;forceSelection;type="text";autoZIndex=!0;baseZIndex=0;ariaLabel;dropdownAriaLabel;ariaLabelledBy;dropdownIcon;unique=!0;group;completeOnFocus=!1;showClear=!1;field;dropdown;showEmptyMessage=!0;dropdownMode="blank";multiple;tabindex;dataKey;emptyMessage;showTransitionOptions=".12s cubic-bezier(0, 0, 0.2, 1)";hideTransitionOptions=".1s linear";autofocus;autocomplete="off";optionGroupChildren="items";optionGroupLabel="label";overlayOptions;get suggestions(){return this._suggestions()}set suggestions(e){this._suggestions.set(e),this.handleSuggestionsChange()}get itemSize(){return this._itemSize}set itemSize(e){this._itemSize=e,console.log("The itemSize property is deprecated, use virtualScrollItemSize property instead.")}optionLabel;optionValue;id;searchMessage;emptySelectionMessage;selectionMessage;autoOptionFocus=!1;selectOnFocus;searchLocale;optionDisabled;focusOnHover=!0;typeahead=!0;variant;fluid=!1;completeMethod=new C;onSelect=new C;onUnselect=new C;onFocus=new C;onBlur=new C;onDropdownClick=new C;onClear=new C;onKeyUp=new C;onShow=new C;onHide=new C;onLazyLoad=new C;containerEL;inputEL;multiInputEl;multiContainerEL;dropdownButton;itemsViewChild;scroller;overlayViewChild;_itemSize;itemsWrapper;itemTemplate;emptyTemplate;headerTemplate;footerTemplate;selectedItemTemplate;groupTemplate;loaderTemplate;removeIconTemplate;loadingIconTemplate;clearIconTemplate;dropdownIconTemplate;primeng=q(Ie);value;_suggestions=L(null);onModelChange=()=>{};onModelTouched=()=>{};timeout;overlayVisible;suggestionsUpdated;highlightOption;highlightOptionChanged;focused=!1;_filled;get filled(){return this._filled}set filled(e){this._filled=e}loading;scrollHandler;listId;searchTimeout;dirty=!1;_itemTemplate;_groupTemplate;_selectedItemTemplate;_headerTemplate;_emptyTemplate;_footerTemplate;_loaderTemplate;_removeIconTemplate;_loadingIconTemplate;_clearIconTemplate;_dropdownIconTemplate;modelValue=L(null);focusedMultipleOptionIndex=L(-1);focusedOptionIndex=L(-1);_componentStyle=q(De);visibleOptions=j(()=>this.group?this.flatOptions(this._suggestions()):this._suggestions()||[]);inputValue=j(()=>{let e=this.modelValue(),o=this.optionValueSelected?(this.suggestions||[]).find(i=>M(i,this.optionValue)===e):e;if(A(e))if(typeof e=="object"||this.optionValueSelected){let i=this.getOptionLabel(o);return i??e}else return e;else return""});get focusedMultipleOptionId(){return this.focusedMultipleOptionIndex()!==-1?`${this.id}_multiple_option_${this.focusedMultipleOptionIndex()}`:null}get focusedOptionId(){return this.focusedOptionIndex()!==-1?`${this.id}_${this.focusedOptionIndex()}`:null}get rootClass(){return this._componentStyle.classes.root({instance:this})}get inputMultipleClass(){return this._componentStyle.classes.inputMultiple({instance:this})}get panelClass(){return{"p-autocomplete-overlay p-component":!0,"p-input-filled":this.config.inputStyle()==="filled"||this.config.inputVariant()==="filled","p-ripple-disabled":this.config.ripple()===!1}}get inputClass(){return{"p-autocomplete-input":!this.multiple,"p-autocomplete-dd-input":this.dropdown}}get searchResultMessageText(){return A(this.visibleOptions())&&this.overlayVisible?this.searchMessageText.replaceAll("{0}",this.visibleOptions().length):this.emptySearchMessageText}get searchMessageText(){return this.searchMessage||this.config.translation.searchMessage||""}get emptySearchMessageText(){return this.emptyMessage||this.config.translation.emptySearchMessage||""}get selectionMessageText(){return this.selectionMessage||this.config.translation.selectionMessage||""}get emptySelectionMessageText(){return this.emptySelectionMessage||this.config.translation.emptySelectionMessage||""}get selectedMessageText(){return this.hasSelectedOption()?this.selectionMessageText.replaceAll("{0}",this.multiple?this.modelValue().length:"1"):this.emptySelectionMessageText}get ariaSetSize(){return this.visibleOptions().filter(e=>!this.isOptionGroup(e)).length}get listLabel(){return this.config.getTranslation(we.ARIA).listLabel}get virtualScrollerDisabled(){return!this.virtualScroll}get optionValueSelected(){return typeof this.modelValue()=="string"&&this.optionValue}chipItemClass(e){return this._componentStyle.classes.chipItem({instance:this,i:e})}optionClass(e,o,i){return{"p-autocomplete-option":!0,"p-autocomplete-option-selected":this.isSelected(e),"p-focus":this.focusedOptionIndex()===this.getOptionIndex(o,i),"p-disabled":this.isOptionDisabled(e)}}constructor(e,o){super(),this.overlayService=e,this.zone=o,ue(()=>{this.filled=A(this.modelValue())})}ngOnInit(){super.ngOnInit(),this.id=this.id||xe("pn_id_"),this.cd.detectChanges()}templates;ngAfterContentInit(){this.templates.forEach(e=>{switch(e.getType()){case"item":this._itemTemplate=e.template;break;case"group":this._groupTemplate=e.template;break;case"selecteditem":this._selectedItemTemplate=e.template;break;case"selectedItem":this._selectedItemTemplate=e.template;break;case"header":this._headerTemplate=e.template;break;case"empty":this._emptyTemplate=e.template;break;case"footer":this._footerTemplate=e.template;break;case"loader":this._loaderTemplate=e.template;break;case"removetokenicon":this._removeIconTemplate=e.template;break;case"loadingicon":this._loadingIconTemplate=e.template;break;case"clearicon":this._clearIconTemplate=e.template;break;case"dropdownicon":this._dropdownIconTemplate=e.template;break;default:this._itemTemplate=e.template;break}})}ngAfterViewChecked(){this.suggestionsUpdated&&this.overlayViewChild&&this.zone.runOutsideAngular(()=>{setTimeout(()=>{this.overlayViewChild&&this.overlayViewChild.alignOverlay()},1),this.suggestionsUpdated=!1})}handleSuggestionsChange(){if(this.loading){this._suggestions()?.length>0||this.showEmptyMessage||this.emptyTemplate?this.show():this.hide();let e=this.overlayVisible&&this.autoOptionFocus?this.findFirstFocusedOptionIndex():-1;this.focusedOptionIndex.set(e),this.suggestionsUpdated=!0,this.loading=!1,this.cd.markForCheck()}}flatOptions(e){return(e||[]).reduce((o,i,n)=>{o.push({optionGroup:i,group:!0,index:n});let p=this.getOptionGroupChildren(i);return p&&p.forEach(x=>o.push(x)),o},[])}isOptionGroup(e){return this.optionGroupLabel&&e.optionGroup&&e.group}findFirstOptionIndex(){return this.visibleOptions().findIndex(e=>this.isValidOption(e))}findLastOptionIndex(){return W(this.visibleOptions(),e=>this.isValidOption(e))}findFirstFocusedOptionIndex(){let e=this.findSelectedOptionIndex();return e<0?this.findFirstOptionIndex():e}findLastFocusedOptionIndex(){let e=this.findSelectedOptionIndex();return e<0?this.findLastOptionIndex():e}findSelectedOptionIndex(){return this.hasSelectedOption()?this.visibleOptions().findIndex(e=>this.isValidSelectedOption(e)):-1}findNextOptionIndex(e){let o=e<this.visibleOptions().length-1?this.visibleOptions().slice(e+1).findIndex(i=>this.isValidOption(i)):-1;return o>-1?o+e+1:e}findPrevOptionIndex(e){let o=e>0?W(this.visibleOptions().slice(0,e),i=>this.isValidOption(i)):-1;return o>-1?o:e}isValidSelectedOption(e){return this.isValidOption(e)&&this.isSelected(e)}isValidOption(e){return e&&!(this.isOptionDisabled(e)||this.isOptionGroup(e))}isOptionDisabled(e){return this.optionDisabled?M(e,this.optionDisabled):!1}isSelected(e){return this.multiple?this.unique?this.modelValue()?.find(o=>Z(o,this.getOptionValue(e),this.equalityKey())):!1:Z(this.modelValue(),this.getOptionValue(e),this.equalityKey())}isOptionMatched(e,o){return this.isValidOption(e)&&this.getOptionLabel(e).toLocaleLowerCase(this.searchLocale)===o.toLocaleLowerCase(this.searchLocale)}isInputClicked(e){return e.target===this.inputEL.nativeElement}isDropdownClicked(e){return this.dropdownButton?.nativeElement?e.target===this.dropdownButton.nativeElement||this.dropdownButton.nativeElement.contains(e.target):!1}equalityKey(){return this.dataKey}onContainerClick(e){this.disabled||this.loading||this.isInputClicked(e)||this.isDropdownClicked(e)||(!this.overlayViewChild||!this.overlayViewChild.overlayViewChild?.nativeElement.contains(e.target))&&k(this.inputEL.nativeElement)}handleDropdownClick(e){let o;this.overlayVisible?this.hide(!0):(k(this.inputEL.nativeElement),o=this.inputEL.nativeElement.value,this.dropdownMode==="blank"?this.search(e,"","dropdown"):this.dropdownMode==="current"&&this.search(e,o,"dropdown")),this.onDropdownClick.emit({originalEvent:e,query:o})}onInput(e){if(this.typeahead){this.searchTimeout&&clearTimeout(this.searchTimeout);let o=e.target.value;this.maxlength!==null&&(o=o.split("").slice(0,this.maxlength).join("")),!this.multiple&&!this.forceSelection&&this.updateModel(o),o.length===0&&!this.multiple?(this.onClear.emit(),setTimeout(()=>{this.hide()},this.delay/2)):o.length>=this.minLength?(this.focusedOptionIndex.set(-1),this.searchTimeout=setTimeout(()=>{this.search(e,o,"input")},this.delay)):this.hide()}}onInputChange(e){if(this.forceSelection){let o=!1;if(this.visibleOptions()){let i=this.visibleOptions().find(n=>this.isOptionMatched(n,this.inputEL.nativeElement.value||""));i!==void 0&&(o=!0,!this.isSelected(i)&&this.onOptionSelect(e,i))}o||(this.inputEL.nativeElement.value="",!this.multiple&&this.updateModel(null))}}onInputFocus(e){if(this.disabled)return;!this.dirty&&this.completeOnFocus&&this.search(e,e.target.value,"focus"),this.dirty=!0,this.focused=!0;let o=this.focusedOptionIndex()!==-1?this.focusedOptionIndex():this.overlayVisible&&this.autoOptionFocus?this.findFirstFocusedOptionIndex():-1;this.focusedOptionIndex.set(o),this.overlayVisible&&this.scrollInView(this.focusedOptionIndex()),this.onFocus.emit(e)}onMultipleContainerFocus(e){this.disabled||(this.focused=!0)}onMultipleContainerBlur(e){this.focusedMultipleOptionIndex.set(-1),this.focused=!1}onMultipleContainerKeyDown(e){if(this.disabled){e.preventDefault();return}switch(e.code){case"ArrowLeft":this.onArrowLeftKeyOnMultiple(e);break;case"ArrowRight":this.onArrowRightKeyOnMultiple(e);break;case"Backspace":this.onBackspaceKeyOnMultiple(e);break;default:break}}onInputBlur(e){this.dirty=!1,this.focused=!1,this.focusedOptionIndex.set(-1),this.onModelTouched(),this.onBlur.emit(e)}onInputPaste(e){this.onKeyDown(e)}onInputKeyUp(e){this.onKeyUp.emit(e)}onKeyDown(e){if(this.disabled){e.preventDefault();return}switch(e.code){case"ArrowDown":this.onArrowDownKey(e);break;case"ArrowUp":this.onArrowUpKey(e);break;case"ArrowLeft":this.onArrowLeftKey(e);break;case"ArrowRight":this.onArrowRightKey(e);break;case"Home":this.onHomeKey(e);break;case"End":this.onEndKey(e);break;case"PageDown":this.onPageDownKey(e);break;case"PageUp":this.onPageUpKey(e);break;case"Enter":case"NumpadEnter":this.onEnterKey(e);break;case"Escape":this.onEscapeKey(e);break;case"Tab":this.onTabKey(e);break;case"Backspace":this.onBackspaceKey(e);break;case"ShiftLeft":case"ShiftRight":break;default:break}}onArrowDownKey(e){if(!this.overlayVisible)return;let o=this.focusedOptionIndex()!==-1?this.findNextOptionIndex(this.focusedOptionIndex()):this.findFirstFocusedOptionIndex();this.changeFocusedOptionIndex(e,o),e.preventDefault(),e.stopPropagation()}onArrowUpKey(e){if(this.overlayVisible)if(e.altKey)this.focusedOptionIndex()!==-1&&this.onOptionSelect(e,this.visibleOptions()[this.focusedOptionIndex()]),this.overlayVisible&&this.hide(),e.preventDefault();else{let o=this.focusedOptionIndex()!==-1?this.findPrevOptionIndex(this.focusedOptionIndex()):this.findLastFocusedOptionIndex();this.changeFocusedOptionIndex(e,o),e.preventDefault(),e.stopPropagation()}}get hasFluid(){let o=this.el.nativeElement.closest("p-fluid");return this.fluid||!!o}onArrowLeftKey(e){let o=e.currentTarget;this.focusedOptionIndex.set(-1),this.multiple&&(ye(o.value)&&this.hasSelectedOption()?(k(this.multiContainerEL.nativeElement),this.focusedMultipleOptionIndex.set(this.modelValue().length)):e.stopPropagation())}onArrowRightKey(e){this.focusedOptionIndex.set(-1),this.multiple&&e.stopPropagation()}onHomeKey(e){let{currentTarget:o}=e,i=o.value.length;o.setSelectionRange(0,e.shiftKey?i:0),this.focusedOptionIndex.set(-1),e.preventDefault()}onEndKey(e){let{currentTarget:o}=e,i=o.value.length;o.setSelectionRange(e.shiftKey?0:i,i),this.focusedOptionIndex.set(-1),e.preventDefault()}onPageDownKey(e){this.scrollInView(this.visibleOptions().length-1),e.preventDefault()}onPageUpKey(e){this.scrollInView(0),e.preventDefault()}onEnterKey(e){this.typeahead||this.multiple&&(this.updateModel([...this.modelValue()||[],e.target.value]),this.inputEL.nativeElement.value=""),this.overlayVisible?(this.focusedOptionIndex()!==-1&&this.onOptionSelect(e,this.visibleOptions()[this.focusedOptionIndex()]),this.hide()):this.onArrowDownKey(e),e.preventDefault()}onEscapeKey(e){this.overlayVisible&&this.hide(!0),e.preventDefault()}onTabKey(e){this.focusedOptionIndex()!==-1&&this.onOptionSelect(e,this.visibleOptions()[this.focusedOptionIndex()]),this.overlayVisible&&this.hide()}onBackspaceKey(e){if(this.multiple){if(A(this.modelValue())&&!this.inputEL.nativeElement.value){let o=this.modelValue()[this.modelValue().length-1],i=this.modelValue().slice(0,-1);this.updateModel(i),this.onUnselect.emit({originalEvent:e,value:o})}e.stopPropagation()}!this.multiple&&this.showClear&&this.findSelectedOptionIndex()!=-1&&this.clear()}onArrowLeftKeyOnMultiple(e){let o=this.focusedMultipleOptionIndex()<1?0:this.focusedMultipleOptionIndex()-1;this.focusedMultipleOptionIndex.set(o)}onArrowRightKeyOnMultiple(e){let o=this.focusedMultipleOptionIndex();o++,this.focusedMultipleOptionIndex.set(o),o>this.modelValue().length-1&&(this.focusedMultipleOptionIndex.set(-1),k(this.inputEL.nativeElement))}onBackspaceKeyOnMultiple(e){this.focusedMultipleOptionIndex()!==-1&&this.removeOption(e,this.focusedMultipleOptionIndex())}onOptionSelect(e,o,i=!0){let n=this.getOptionValue(o);this.multiple?(this.inputEL.nativeElement.value="",this.isSelected(o)||this.updateModel([...this.modelValue()||[],n])):this.updateModel(n),this.onSelect.emit({originalEvent:e,value:o}),i&&this.hide(!0)}onOptionMouseEnter(e,o){this.focusOnHover&&this.changeFocusedOptionIndex(e,o)}search(e,o,i){o!=null&&(i==="input"&&o.trim().length===0||(this.loading=!0,this.completeMethod.emit({originalEvent:e,query:o})))}removeOption(e,o){e.stopPropagation();let i=this.modelValue()[o],n=this.modelValue().filter((p,x)=>x!==o).map(p=>this.getOptionValue(p));this.updateModel(n),this.onUnselect.emit({originalEvent:e,value:i}),k(this.inputEL.nativeElement)}updateModel(e){this.value=e,this.modelValue.set(e),this.onModelChange(e),this.updateInputValue(),this.cd.markForCheck()}updateInputValue(){this.inputEL&&this.inputEL.nativeElement&&(this.multiple?this.inputEL.nativeElement.value="":this.inputEL.nativeElement.value=this.inputValue())}autoUpdateModel(){if((this.selectOnFocus||this.autoHighlight)&&this.autoOptionFocus&&!this.hasSelectedOption()){let e=this.findFirstFocusedOptionIndex();this.focusedOptionIndex.set(e),this.onOptionSelect(null,this.visibleOptions()[this.focusedOptionIndex()],!1)}}scrollInView(e=-1){let o=e!==-1?`${this.id}_${e}`:this.focusedOptionId;if(this.itemsViewChild&&this.itemsViewChild.nativeElement){let i=Q(this.itemsViewChild.nativeElement,`li[id="${o}"]`);i?i.scrollIntoView&&i.scrollIntoView({block:"nearest",inline:"nearest"}):this.virtualScrollerDisabled||setTimeout(()=>{this.virtualScroll&&this.scroller?.scrollToIndex(e!==-1?e:this.focusedOptionIndex())},0)}}changeFocusedOptionIndex(e,o){this.focusedOptionIndex()!==o&&(this.focusedOptionIndex.set(o),this.scrollInView(),this.selectOnFocus&&this.onOptionSelect(e,this.visibleOptions()[o],!1))}show(e=!1){this.dirty=!0,this.overlayVisible=!0;let o=this.focusedOptionIndex()!==-1?this.focusedOptionIndex():this.autoOptionFocus?this.findFirstFocusedOptionIndex():-1;this.focusedOptionIndex.set(o),e&&k(this.inputEL.nativeElement),e&&k(this.inputEL.nativeElement),this.onShow.emit(),this.cd.markForCheck()}hide(e=!1){let o=()=>{this.dirty=e,this.overlayVisible=!1,this.focusedOptionIndex.set(-1),e&&k(this.inputEL.nativeElement),this.onHide.emit(),this.cd.markForCheck()};setTimeout(()=>{o()},0)}clear(){this.updateModel(null),this.inputEL.nativeElement.value="",this.onClear.emit()}writeValue(e){this.value=e,this.modelValue.set(e),this.updateInputValue(),this.cd.markForCheck()}hasSelectedOption(){return A(this.modelValue())}getAriaPosInset(e){return(this.optionGroupLabel?e-this.visibleOptions().slice(0,e).filter(o=>this.isOptionGroup(o)).length:e)+1}getOptionLabel(e){return this.field||this.optionLabel?M(e,this.field||this.optionLabel):e&&e.label!=null?e.label:e}getOptionValue(e){return this.optionValue?M(e,this.optionValue):e&&e.value!=null?e.value:e}getOptionIndex(e,o){return this.virtualScrollerDisabled?e:o&&o.getItemOptions(e).index}getOptionGroupLabel(e){return this.optionGroupLabel?M(e,this.optionGroupLabel):e&&e.label!=null?e.label:e}getOptionGroupChildren(e){return this.optionGroupChildren?M(e,this.optionGroupChildren):e.items}registerOnChange(e){this.onModelChange=e}registerOnTouched(e){this.onModelTouched=e}setDisabledState(e){this.disabled=e,this.cd.markForCheck()}onOverlayAnimationStart(e){if(e.toState==="visible"&&(this.itemsWrapper=Q(this.overlayViewChild.overlayViewChild?.nativeElement,this.virtualScroll?".p-scroller":".p-autocomplete-panel"),this.virtualScroll&&(this.scroller?.setContentEl(this.itemsViewChild?.nativeElement),this.scroller.viewInit()),this.visibleOptions()&&this.visibleOptions().length))if(this.virtualScroll){let o=this.modelValue()?this.focusedOptionIndex():-1;o!==-1&&this.scroller?.scrollToIndex(o)}else{let o=Q(this.itemsWrapper,".p-autocomplete-item.p-highlight");o&&o.scrollIntoView({block:"nearest",inline:"center"})}}ngOnDestroy(){this.scrollHandler&&(this.scrollHandler.destroy(),this.scrollHandler=null),super.ngOnDestroy()}static \u0275fac=function(o){return new(o||t)(B(be),B(oe))};static \u0275cmp=ie({type:t,selectors:[["p-autoComplete"],["p-autocomplete"],["p-auto-complete"]],contentQueries:function(o,i,n){if(o&1&&(b(n,qe,5),b(n,Be,5),b(n,He,5),b(n,Ge,5),b(n,Ue,5),b(n,Pe,5),b(n,Ne,5),b(n,je,5),b(n,Ze,5),b(n,We,5),b(n,Je,5),b(n,Ce,4)),o&2){let p;g(p=f())&&(i.itemTemplate=p.first),g(p=f())&&(i.emptyTemplate=p.first),g(p=f())&&(i.headerTemplate=p.first),g(p=f())&&(i.footerTemplate=p.first),g(p=f())&&(i.selectedItemTemplate=p.first),g(p=f())&&(i.groupTemplate=p.first),g(p=f())&&(i.loaderTemplate=p.first),g(p=f())&&(i.removeIconTemplate=p.first),g(p=f())&&(i.loadingIconTemplate=p.first),g(p=f())&&(i.clearIconTemplate=p.first),g(p=f())&&(i.dropdownIconTemplate=p.first),g(p=f())&&(i.templates=p)}},viewQuery:function(o,i){if(o&1&&(S(Xe,5),S(Ye,5),S(et,5),S(tt,5),S(ot,5),S(it,5),S(nt,5),S(lt,5)),o&2){let n;g(n=f())&&(i.containerEL=n.first),g(n=f())&&(i.inputEL=n.first),g(n=f())&&(i.multiInputEl=n.first),g(n=f())&&(i.multiContainerEL=n.first),g(n=f())&&(i.dropdownButton=n.first),g(n=f())&&(i.itemsViewChild=n.first),g(n=f())&&(i.scroller=n.first),g(n=f())&&(i.overlayViewChild=n.first)}},inputs:{minLength:[2,"minLength","minLength",E],delay:[2,"delay","delay",E],style:"style",panelStyle:"panelStyle",styleClass:"styleClass",panelStyleClass:"panelStyleClass",inputStyle:"inputStyle",inputId:"inputId",inputStyleClass:"inputStyleClass",placeholder:"placeholder",readonly:[2,"readonly","readonly",_],disabled:[2,"disabled","disabled",_],scrollHeight:"scrollHeight",lazy:[2,"lazy","lazy",_],virtualScroll:[2,"virtualScroll","virtualScroll",_],virtualScrollItemSize:[2,"virtualScrollItemSize","virtualScrollItemSize",E],virtualScrollOptions:"virtualScrollOptions",maxlength:[2,"maxlength","maxlength",e=>E(e,null)],name:"name",required:[2,"required","required",_],size:"size",appendTo:"appendTo",autoHighlight:[2,"autoHighlight","autoHighlight",_],forceSelection:[2,"forceSelection","forceSelection",_],type:"type",autoZIndex:[2,"autoZIndex","autoZIndex",_],baseZIndex:[2,"baseZIndex","baseZIndex",E],ariaLabel:"ariaLabel",dropdownAriaLabel:"dropdownAriaLabel",ariaLabelledBy:"ariaLabelledBy",dropdownIcon:"dropdownIcon",unique:[2,"unique","unique",_],group:[2,"group","group",_],completeOnFocus:[2,"completeOnFocus","completeOnFocus",_],showClear:[2,"showClear","showClear",_],field:"field",dropdown:[2,"dropdown","dropdown",_],showEmptyMessage:[2,"showEmptyMessage","showEmptyMessage",_],dropdownMode:"dropdownMode",multiple:[2,"multiple","multiple",_],tabindex:[2,"tabindex","tabindex",E],dataKey:"dataKey",emptyMessage:"emptyMessage",showTransitionOptions:"showTransitionOptions",hideTransitionOptions:"hideTransitionOptions",autofocus:[2,"autofocus","autofocus",_],autocomplete:"autocomplete",optionGroupChildren:"optionGroupChildren",optionGroupLabel:"optionGroupLabel",overlayOptions:"overlayOptions",suggestions:"suggestions",itemSize:"itemSize",optionLabel:"optionLabel",optionValue:"optionValue",id:"id",searchMessage:"searchMessage",emptySelectionMessage:"emptySelectionMessage",selectionMessage:"selectionMessage",autoOptionFocus:[2,"autoOptionFocus","autoOptionFocus",_],selectOnFocus:[2,"selectOnFocus","selectOnFocus",_],searchLocale:[2,"searchLocale","searchLocale",_],optionDisabled:"optionDisabled",focusOnHover:[2,"focusOnHover","focusOnHover",_],typeahead:[2,"typeahead","typeahead",_],variant:"variant",fluid:[2,"fluid","fluid",_]},outputs:{completeMethod:"completeMethod",onSelect:"onSelect",onUnselect:"onUnselect",onFocus:"onFocus",onBlur:"onBlur",onDropdownClick:"onDropdownClick",onClear:"onClear",onKeyUp:"onKeyUp",onShow:"onShow",onHide:"onHide",onLazyLoad:"onLazyLoad"},features:[ce([ro,De]),le],decls:11,vars:15,consts:[["container",""],["overlay",""],["content",""],["focusInput",""],["multiContainer",""],["token",""],["removeicon",""],["ddBtn",""],["buildInItems",""],["scroller",""],["loader",""],["items",""],["empty",""],[2,"position","relative",3,"click","ngClass","ngStyle"],["pInputText","","aria-autocomplete","list","role","combobox",3,"pAutoFocus","ngClass","ngStyle","class","type","variant","autocomplete","required","name","pSize","tabindex","readonly","disabled","fluid","input","keydown","change","focus","blur","paste","keyup",4,"ngIf"],[4,"ngIf"],["role","listbox",3,"ngClass","tabindex","focus","blur","keydown",4,"ngIf"],["type","button","class","p-autocomplete-dropdown","pRipple","",3,"disabled","click",4,"ngIf"],[3,"visibleChange","onAnimationStart","onHide","visible","options","target","appendTo","showTransitionOptions","hideTransitionOptions"],["pInputText","","aria-autocomplete","list","role","combobox",3,"input","keydown","change","focus","blur","paste","keyup","pAutoFocus","ngClass","ngStyle","type","variant","autocomplete","required","name","pSize","tabindex","readonly","disabled","fluid"],[3,"styleClass","click",4,"ngIf"],["class","p-autocomplete-clear-icon",3,"click",4,"ngIf"],[3,"click","styleClass"],[1,"p-autocomplete-clear-icon",3,"click"],[4,"ngTemplateOutlet"],["role","listbox",3,"focus","blur","keydown","ngClass","tabindex"],["role","option",3,"ngClass",4,"ngFor","ngForOf"],["role","option",1,"p-autocomplete-input-chip"],["role","combobox","aria-autocomplete","list",3,"input","keydown","change","focus","blur","paste","keyup","pAutoFocus","ngClass","ngStyle","autocomplete","required","tabindex","readonly","disabled"],["role","option",3,"ngClass"],[4,"ngTemplateOutlet","ngTemplateOutletContext"],["styleClass","p-autocomplete-chip",3,"label","removable",4,"ngIf"],["styleClass","p-autocomplete-chip",3,"label","removable"],[1,"p-autocomplete-chip-icon",3,"click"],[3,"styleClass"],[3,"styleClass","spin",4,"ngIf"],["class","p-autocomplete-loader pi-spin ",4,"ngIf"],[3,"styleClass","spin"],[1,"p-autocomplete-loader","pi-spin"],["type","button","pRipple","",1,"p-autocomplete-dropdown",3,"click","disabled"],[3,"ngClass",4,"ngIf"],[3,"ngClass"],[3,"ngClass","ngStyle"],[1,"p-autocomplete-list-container"],[3,"items","style","itemSize","autoSize","lazy","options","onLazyLoad",4,"ngIf"],["role","status","aria-live","polite",1,"p-hidden-accessible"],[3,"onLazyLoad","items","itemSize","autoSize","lazy","options"],["role","listbox",1,"p-autocomplete-list",3,"ngClass"],["ngFor","",3,"ngForOf"],["class","p-autocomplete-empty-message","role","option",3,"ngStyle",4,"ngIf"],["role","option",1,"p-autocomplete-option-group",3,"ngStyle"],["pRipple","","role","option",3,"click","mouseenter","ngStyle","ngClass"],["role","option",1,"p-autocomplete-empty-message",3,"ngStyle"],[4,"ngIf","ngIfElse"]],template:function(o,i){if(o&1){let n=T();m(0,"div",13,0),w("click",function(x){return u(n),d(i.onContainerClick(x))}),c(2,ut,2,25,"input",14)(3,gt,3,2,"ng-container",15)(4,Ot,6,26,"ul",16)(5,Et,3,2,"ng-container",15)(6,zt,4,5,"button",17),m(7,"p-overlay",18,1),se("visibleChange",function(x){return u(n),re(i.overlayVisible,x)||(i.overlayVisible=x),d(x)}),w("onAnimationStart",function(x){return u(n),d(i.onOverlayAnimationStart(x))})("onHide",function(){return u(n),d(i.hide())}),c(9,no,10,11,"ng-template",null,2,$),h()()}o&2&&(F(i.styleClass),r("ngClass",i.rootClass)("ngStyle",i.style),s(2),r("ngIf",!i.multiple),s(),r("ngIf",i.filled&&!i.disabled&&i.showClear&&!i.loading),s(),r("ngIf",i.multiple),s(),r("ngIf",i.loading),s(),r("ngIf",i.dropdown),s(),pe("visible",i.overlayVisible),r("options",i.overlayOptions)("target","@parent")("appendTo",i.appendTo)("showTransitionOptions",i.showTransitionOptions)("hideTransitionOptions",i.hideTransitionOptions))},dependencies:[fe,de,me,_e,ge,he,Le,Se,Ae,Fe,Ve,$e,Ee,Me,ke,ze,J],encapsulation:2,changeDetection:0})}return t})(),Ko=(()=>{class t{static \u0275fac=function(o){return new(o||t)};static \u0275mod=ne({type:t});static \u0275inj=ee({imports:[Re,J]})}return t})();export{Re as a,Ko as b};
