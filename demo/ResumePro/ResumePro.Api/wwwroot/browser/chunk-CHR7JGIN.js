import{a as rt}from"./chunk-IKWOIRYM.js";import{a as et}from"./chunk-YUUY53IN.js";import{a as it,b as lt}from"./chunk-3BQEJCHT.js";import{d as ot}from"./chunk-QXZQXA5D.js";import{c as tt,g as nt}from"./chunk-TI2YGS5M.js";import{Aa as Y,Da as Z,ia as W,sa as X,ta as D}from"./chunk-ZHGKNXMS.js";import{Ab as P,Bb as x,Cb as H,Db as T,Fb as y,Gb as c,Jc as j,Kb as C,Lb as B,Lc as K,Mb as b,Nb as m,Oc as U,Pa as s,Pc as G,Q as M,Qb as L,R as V,Uc as J,W as E,Yb as $,aa as p,ab as Q,ba as d,bb as A,ea as S,eb as F,gb as f,ka as w,mc as q,nb as g,ob as l,pa as z,rb as R,sb as I,sc as a,tc as N,xb as _,yb as h,zb as k}from"./chunk-DKCBYRU7.js";import{a as O}from"./chunk-GAL4ENT6.js";var at=["content"],ut=["dropdownicon"],pt=["container"],dt=["defaultbtn"],ct=["menu"];function bt(n,u){n&1&&H(0)}function mt(n,u){if(n&1){let t=T();P(0),_(1,"button",10),y("click",function(e){p(t);let o=c();return d(o.onDefaultButtonClick(e))}),f(2,bt,1,0,"ng-container",11),h(),x()}if(n&2){let t=c();s(),l("severity",t.severity)("text",t.text)("outlined",t.outlined)("size",t.size)("icon",t.icon)("iconPos",t.iconPos)("disabled",t.disabled)("pAutoFocus",t.autofocus)("pTooltip",t.tooltip)("tooltipOptions",t.tooltipOptions),g("tabindex",t.tabindex)("aria-label",(t.buttonProps==null?null:t.buttonProps.ariaLabel)||t.label),s(),l("ngTemplateOutlet",t.contentTemplate||t._contentTemplate)}}function ft(n,u){if(n&1){let t=T();_(0,"button",12,3),y("click",function(e){p(t);let o=c();return d(o.onDefaultButtonClick(e))}),h()}if(n&2){let t=c();l("severity",t.severity)("text",t.text)("outlined",t.outlined)("size",t.size)("icon",t.icon)("iconPos",t.iconPos)("label",t.label)("disabled",t.buttonDisabled)("pAutoFocus",t.autofocus)("pTooltip",t.tooltip)("tooltipOptions",t.tooltipOptions),g("tabindex",t.tabindex)("aria-label",t.buttonProps==null?null:t.buttonProps.ariaLabel)}}function _t(n,u){if(n&1&&k(0,"span"),n&2){let t=c();I(t.dropdownIcon)}}function wt(n,u){n&1&&k(0,"ChevronDownIcon")}function ht(n,u){}function yt(n,u){n&1&&f(0,ht,0,0,"ng-template")}function gt(n,u){if(n&1&&(P(0),f(1,wt,1,0,"ChevronDownIcon",8)(2,yt,1,0,null,11),x()),n&2){let t=c();s(),l("ngIf",!t.dropdownIconTemplate&&!t._dropdownIconTemplate),s(),l("ngTemplateOutlet",t.dropdownIconTemplate||t._dropdownIconTemplate)}}var Tt=({dt:n})=>`
.p-splitbutton {
    display: inline-flex;
    position: relative;
    border-radius: ${n("splitbutton.border.radius")};
}

.p-splitbutton-button.p-button {
    border-start-end-radius: 0;
    border-end-end-radius: 0;
    border-right: 0 none;
}

.p-splitbutton-button.p-button:focus-visible,
.p-splitbutton-dropdown.p-button:focus-visible {
    z-index: 1;
}

.p-splitbutton-button.p-button:not(:disabled):hover,
.p-splitbutton-button.p-button:not(:disabled):active {
    border-right: 0 none;
}

.p-splitbutton-dropdown.p-button {
    border-start-start-radius: 0;
    border-end-start-radius: 0;
}

.p-splitbutton .p-menu {
    min-width: 100%;
}

.p-splitbutton-fluid {
    display: flex;
}

.p-splitbutton-rounded .p-splitbutton-dropdown {
    border-start-end-radius: ${n("splitbutton.rounded.border.radius")};
    border-end-end-radius: ${n("splitbutton.rounded.border.radius")};
}

.p-splitbutton-rounded > .p-splitbutton-button {
    border-start-start-radius: ${n("splitbutton.rounded.border.radius")};
    border-end-start-radius: ${n("splitbutton.rounded.border.radius")};
}

.p-splitbutton-raised {
    box-shadow: ${n("splitbutton.raised.shadow")};
}
`,Ct={root:({props:n})=>["p-splitbutton p-component",{"p-splitbutton-raised":n.raised,"p-splitbutton-rounded":n.rounded,"p-splitbutton-fluid":n.fluid}],pcButton:"p-splitbutton-button",pcDropdown:"p-splitbutton-dropdown"},st=(()=>{class n extends Y{name="splitbutton";theme=Tt;classes=Ct;static \u0275fac=(()=>{let t;return function(e){return(t||(t=S(n)))(e||n)}})();static \u0275prov=M({token:n,factory:n.\u0275fac})}return n})();var Bt=(()=>{class n extends Z{model;severity;raised=!1;rounded=!1;text=!1;outlined=!1;size=null;plain=!1;icon;iconPos="left";label;tooltip;tooltipOptions;style;styleClass;menuStyle;menuStyleClass;dropdownIcon;appendTo;dir;expandAriaLabel;showTransitionOptions=".12s cubic-bezier(0, 0, 0.2, 1)";hideTransitionOptions=".1s linear";buttonProps;menuButtonProps;autofocus;set disabled(t){this._disabled=t,this._buttonDisabled=t,this.menuButtonDisabled=t}get disabled(){return this._disabled}tabindex;set menuButtonDisabled(t){this.disabled?this._menuButtonDisabled=this.disabled:this._menuButtonDisabled=t}get menuButtonDisabled(){return this._menuButtonDisabled}set buttonDisabled(t){this.disabled?this.buttonDisabled=this.disabled:this._buttonDisabled=t}get buttonDisabled(){return this._buttonDisabled}onClick=new w;onMenuHide=new w;onMenuShow=new w;onDropdownClick=new w;containerViewChild;buttonViewChild;menu;contentTemplate;dropdownIconTemplate;templates;ariaId;isExpanded=z(!1);_disabled;_buttonDisabled;_menuButtonDisabled;_componentStyle=E(st);_contentTemplate;_dropdownIconTemplate;ngOnInit(){super.ngOnInit(),this.ariaId=W("pn_id_")}ngAfterContentInit(){this.templates?.forEach(t=>{switch(t.getType()){case"content":this._contentTemplate=t.template;break;case"dropdownicon":this._dropdownIconTemplate=t.template;break;default:this._contentTemplate=t.template;break}})}get containerClass(){let t={"p-splitbutton p-component":!0,"p-splitbutton-raised":this.raised,"p-splitbutton-rounded":this.rounded,"p-splitbutton-outlined":this.outlined,"p-splitbutton-text":this.text,[`p-splitbutton-${this.size==="small"?"sm":"lg"}`]:this.size};return O({},t)}onDefaultButtonClick(t){this.onClick.emit(t),this.menu.hide()}onDropdownButtonClick(t){this.onDropdownClick.emit(t),this.menu?.toggle({currentTarget:this.containerViewChild?.nativeElement,relativeAlign:this.appendTo==null})}onDropdownButtonKeydown(t){(t.code==="ArrowDown"||t.code==="ArrowUp")&&(this.onDropdownButtonClick(),t.preventDefault())}onHide(){this.isExpanded.set(!1),this.onMenuHide.emit()}onShow(){this.isExpanded.set(!0),this.onMenuShow.emit()}static \u0275fac=(()=>{let t;return function(e){return(t||(t=S(n)))(e||n)}})();static \u0275cmp=Q({type:n,selectors:[["p-splitbutton"],["p-splitButton"],["p-split-button"]],contentQueries:function(i,e,o){if(i&1&&(C(o,at,4),C(o,ut,4),C(o,X,4)),i&2){let r;b(r=m())&&(e.contentTemplate=r.first),b(r=m())&&(e.dropdownIconTemplate=r.first),b(r=m())&&(e.templates=r)}},viewQuery:function(i,e){if(i&1&&(B(pt,5),B(dt,5),B(ct,5)),i&2){let o;b(o=m())&&(e.containerViewChild=o.first),b(o=m())&&(e.buttonViewChild=o.first),b(o=m())&&(e.menu=o.first)}},inputs:{model:"model",severity:"severity",raised:[2,"raised","raised",a],rounded:[2,"rounded","rounded",a],text:[2,"text","text",a],outlined:[2,"outlined","outlined",a],size:"size",plain:[2,"plain","plain",a],icon:"icon",iconPos:"iconPos",label:"label",tooltip:"tooltip",tooltipOptions:"tooltipOptions",style:"style",styleClass:"styleClass",menuStyle:"menuStyle",menuStyleClass:"menuStyleClass",dropdownIcon:"dropdownIcon",appendTo:"appendTo",dir:"dir",expandAriaLabel:"expandAriaLabel",showTransitionOptions:"showTransitionOptions",hideTransitionOptions:"hideTransitionOptions",buttonProps:"buttonProps",menuButtonProps:"menuButtonProps",autofocus:[2,"autofocus","autofocus",a],disabled:[2,"disabled","disabled",a],tabindex:[2,"tabindex","tabindex",N],menuButtonDisabled:"menuButtonDisabled",buttonDisabled:"buttonDisabled"},outputs:{onClick:"onClick",onMenuHide:"onMenuHide",onMenuShow:"onMenuShow",onDropdownClick:"onDropdownClick"},features:[$([st]),F],decls:10,vars:26,consts:[["container",""],["defaultButton",""],["menu",""],["defaultbtn",""],[3,"ngClass","ngStyle"],[4,"ngIf","ngIfElse"],["type","button","pButton","","pRipple","",1,"p-splitbutton-dropdown","p-button-icon-only",3,"click","keydown","size","severity","text","outlined","disabled"],[3,"class",4,"ngIf"],[4,"ngIf"],[3,"onHide","onShow","id","popup","model","styleClass","appendTo","showTransitionOptions","hideTransitionOptions"],["type","button","pButton","","pRipple","",1,"p-splitbutton-button",3,"click","severity","text","outlined","size","icon","iconPos","disabled","pAutoFocus","pTooltip","tooltipOptions"],[4,"ngTemplateOutlet"],["type","button","pButton","","pRipple","",1,"p-splitbutton-button",3,"click","severity","text","outlined","size","icon","iconPos","label","disabled","pAutoFocus","pTooltip","tooltipOptions"]],template:function(i,e){if(i&1){let o=T();_(0,"div",4,0),f(2,mt,3,13,"ng-container",5)(3,ft,2,13,"ng-template",null,1,q),_(5,"button",6),y("click",function(v){return p(o),d(e.onDropdownButtonClick(v))})("keydown",function(v){return p(o),d(e.onDropdownButtonKeydown(v))}),f(6,_t,1,2,"span",7)(7,gt,3,2,"ng-container",8),h(),_(8,"p-tieredMenu",9,2),y("onHide",function(){return p(o),d(e.onHide())})("onShow",function(){return p(o),d(e.onShow())}),h()()}if(i&2){let o=L(4);I(e.styleClass),l("ngClass",e.containerClass)("ngStyle",e.style),s(2),l("ngIf",e.contentTemplate||e._contentTemplate)("ngIfElse",o),s(3),l("size",e.size)("severity",e.severity)("text",e.text)("outlined",e.outlined)("disabled",e.menuButtonDisabled),g("aria-label",(e.menuButtonProps==null?null:e.menuButtonProps.ariaLabel)||e.expandAriaLabel)("aria-haspopup",(e.menuButtonProps==null?null:e.menuButtonProps.ariaHasPopup)||!0)("aria-expanded",(e.menuButtonProps==null?null:e.menuButtonProps.ariaExpanded)||e.isExpanded())("aria-controls",(e.menuButtonProps==null?null:e.menuButtonProps.ariaControls)||e.ariaId),s(),l("ngIf",e.dropdownIcon),s(),l("ngIf",!e.dropdownIcon),s(),R(e.menuStyle),l("id",e.ariaId)("popup",!0)("model",e.model)("styleClass",e.menuStyleClass)("appendTo",e.appendTo)("showTransitionOptions",e.showTransitionOptions)("hideTransitionOptions",e.hideTransitionOptions)}},dependencies:[J,j,K,G,U,ot,rt,tt,et,nt,lt,it,D],encapsulation:2,changeDetection:0})}return n})(),Jt=(()=>{class n{static \u0275fac=function(i){return new(i||n)};static \u0275mod=A({type:n});static \u0275inj=V({imports:[Bt,D,D]})}return n})();export{Bt as a,Jt as b};
