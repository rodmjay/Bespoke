import{a as dt}from"./chunk-SGUPKBVV.js";import{a as ft}from"./chunk-P63N2URC.js";import{g as J,h as ht}from"./chunk-TI2YGS5M.js";import{Aa as pt,D as q,Da as $,H as F,M as W,Y as U,ia as bt,k as rt,sa as ut,t as lt,ta as G,u as ct,v as L}from"./chunk-ZHGKNXMS.js";import{Cb as H,Db as A,Fb as I,Gb as d,Hb as T,Ib as w,Jc as ot,Kb as Q,Lb as x,Mb as l,Nb as c,P as B,Pa as v,Pc as st,Q as X,R as Y,Uc as k,W as f,Wc as j,Yb as et,Za as N,_b as nt,aa as P,ab as g,ba as V,bb as Z,ea as h,eb as m,fb as tt,gb as u,na as p,nb as r,ob as O,pa as R,qb as _,sc as C,tb as y,tc as it,vc as s,wc as at,xb as D,yb as S,zb as M}from"./chunk-DKCBYRU7.js";var mt=["previcon"],_t=["nexticon"],yt=["content"],Tt=["prevButton"],wt=["nextButton"],xt=["inkbar"],Ct=["tabs"],E=["*"],kt=t=>({"p-tablist-viewport":t});function $t(t,b){t&1&&H(0)}function Bt(t,b){if(t&1&&u(0,$t,1,0,"ng-container",11),t&2){let e=d(2);O("ngTemplateOutlet",e.prevIconTemplate||e._prevIconTemplate)}}function Dt(t,b){t&1&&M(0,"ChevronLeftIcon")}function It(t,b){if(t&1){let e=A();D(0,"button",10,3),I("click",function(){P(e);let n=d();return V(n.onPrevButtonClick())}),u(2,Bt,1,1,"ng-container")(3,Dt,1,0,"ChevronLeftIcon"),S()}if(t&2){let e=d();r("aria-label",e.prevButtonAriaLabel)("tabindex",e.tabindex())("data-pc-group-section","navigator"),v(2),y(e.prevIconTemplate||e._prevIconTemplate?2:3)}}function Lt(t,b){t&1&&H(0)}function Ft(t,b){if(t&1&&u(0,Lt,1,0,"ng-container",11),t&2){let e=d(2);O("ngTemplateOutlet",e.nextIconTemplate||e._nextIconTemplate)}}function Et(t,b){t&1&&M(0,"ChevronRightIcon")}function Pt(t,b){if(t&1){let e=A();D(0,"button",12,4),I("click",function(){P(e);let n=d();return V(n.onNextButtonClick())}),u(2,Ft,1,1,"ng-container")(3,Et,1,0,"ChevronRightIcon"),S()}if(t&2){let e=d();r("aria-label",e.nextButtonAriaLabel)("tabindex",e.tabindex())("data-pc-group-section","navigator"),v(2),y(e.nextIconTemplate||e._nextIconTemplate?2:3)}}function Vt(t,b){t&1&&w(0)}var Rt=({dt:t})=>`
.p-tabs {
    display: flex;
    flex-direction: column;
}

.p-tablist {
    display: flex;
    position: relative;
}

.p-tabs-scrollable > .p-tablist {
    overflow: hidden;
}

.p-tablist-viewport {
    overflow-x: auto;
    overflow-y: hidden;
    scroll-behavior: smooth;
    scrollbar-width: none;
    overscroll-behavior: contain auto;
}

.p-tablist-viewport::-webkit-scrollbar {
    display: none;
}

.p-tablist-tab-list {
    position: relative;
    display: flex;
    background: ${t("tabs.tablist.background")};
    border-style: solid;
    border-color: ${t("tabs.tablist.border.color")};
    border-width: ${t("tabs.tablist.border.width")};
}

.p-tablist-content {
    flex-grow: 1;
}

.p-tablist-nav-button {
    all: unset;
    position: absolute !important;
    flex-shrink: 0;
    top: 0;
    z-index: 2;
    height: 100%;
    display: flex;
    align-items: center;
    justify-content: center;
    background: ${t("tabs.nav.button.background")};
    color: ${t("tabs.nav.button.color")};
    width: ${t("tabs.nav.button.width")};
    transition: color ${t("tabs.transition.duration")}, outline-color ${t("tabs.transition.duration")}, box-shadow ${t("tabs.transition.duration")};
    box-shadow: ${t("tabs.nav.button.shadow")};
    outline-color: transparent;
    cursor: pointer;
}

.p-tablist-nav-button:focus-visible {
    z-index: 1;
    box-shadow: ${t("tabs.nav.button.focus.ring.shadow")};
    outline: ${t("tabs.nav.button.focus.ring.width")} ${t("tabs.nav.button.focus.ring.style")} ${t("tabs.nav.button.focus.ring.color")};
    outline-offset: ${t("tabs.nav.button.focus.ring.offset")};
}

.p-tablist-nav-button:hover {
    color: ${t("tabs.nav.button.hover.color")};
}

.p-tablist-prev-button {
    left: 0;
}

.p-tablist-next-button {
    right: 0;
}

.p-tab {
    display: flex;
    align-items: center;
    flex-shrink: 0;
    cursor: pointer;
    user-select: none;
    position: relative;
    border-style: solid;
    white-space: nowrap;
    gap: ${t("tabs.tab.gap")};
    background: ${t("tabs.tab.background")};
    border-width: ${t("tabs.tab.border.width")};
    border-color: ${t("tabs.tab.border.color")};
    color: ${t("tabs.tab.color")};
    padding: ${t("tabs.tab.padding")};
    font-weight: ${t("tabs.tab.font.weight")};
    transition: background ${t("tabs.transition.duration")}, border-color ${t("tabs.transition.duration")}, color ${t("tabs.transition.duration")}, outline-color ${t("tabs.transition.duration")}, box-shadow ${t("tabs.transition.duration")};
    margin: ${t("tabs.tab.margin")};
    outline-color: transparent;
}

.p-tab:not(.p-disabled):focus-visible {
    z-index: 1;
    box-shadow: ${t("tabs.tab.focus.ring.shadow")};
    outline: ${t("tabs.tab.focus.ring.width")} ${t("tabs.tab.focus.ring.style")} ${t("tabs.tab.focus.ring.color")};
    outline-offset: ${t("tabs.tab.focus.ring.offset")};
}

.p-tab:not(.p-tab-active):not(.p-disabled):hover {
    background: ${t("tabs.tab.hover.background")};
    border-color: ${t("tabs.tab.hover.border.color")};
    color: ${t("tabs.tab.hover.color")};
}

.p-tab-active {
    background: ${t("tabs.tab.active.background")};
    border-color: ${t("tabs.tab.active.border.color")};
    color: ${t("tabs.tab.active.color")};
}

.p-tabpanels {
    background: ${t("tabs.tabpanel.background")};
    color: ${t("tabs.tabpanel.color")};
    padding: ${t("tabs.tabpanel.padding")};
    outline: 0 none;
}

.p-tabpanel:focus-visible {
    box-shadow: ${t("tabs.tabpanel.focus.ring.shadow")};
    outline: ${t("tabs.tabpanel.focus.ring.width")} ${t("tabs.tabpanel.focus.ring.style")} ${t("tabs.tabpanel.focus.ring.color")};
    outline-offset: ${t("tabs.tabpanel.focus.ring.offset")};
}

.p-tablist-active-bar {
    z-index: 1;
    display: block;
    position: absolute;
    bottom: ${t("tabs.active.bar.bottom")};
    height: ${t("tabs.active.bar.height")};
    background: ${t("tabs.active.bar.background")};
    transition: 250ms cubic-bezier(0.35, 0, 0.25, 1);
}
`,Nt={root:({props:t})=>["p-tabs p-component",{"p-tabs-scrollable":t.scrollable}]},vt=(()=>{class t extends pt{name="tabs";theme=Rt;classes=Nt;static \u0275fac=(()=>{let e;return function(n){return(e||(e=h(t)))(n||t)}})();static \u0275prov=X({token:t,factory:t.\u0275fac})}return t})();var gt=(()=>{class t extends ${prevIconTemplate;nextIconTemplate;templates;content;prevButton;nextButton;inkbar;tabs;pcTabs=f(B(()=>z));isPrevButtonEnabled=R(!1);isNextButtonEnabled=R(!1);resizeObserver;showNavigators=s(()=>this.pcTabs.showNavigators());tabindex=s(()=>this.pcTabs.tabindex());scrollable=s(()=>this.pcTabs.scrollable());constructor(){super(),at(()=>{this.pcTabs.value(),j(this.platformId)&&setTimeout(()=>{this.updateInkBar()})})}get prevButtonAriaLabel(){return this.config.translation.aria.previous}get nextButtonAriaLabel(){return this.config.translation.aria.next}ngAfterViewInit(){super.ngAfterViewInit(),this.showNavigators()&&j(this.platformId)&&(this.updateButtonState(),this.bindResizeObserver())}_prevIconTemplate;_nextIconTemplate;ngAfterContentInit(){this.templates.forEach(e=>{switch(e.getType()){case"previcon":this._prevIconTemplate=e.template;break;case"nexticon":this._nextIconTemplate=e.template;break}})}ngOnDestroy(){this.unbindResizeObserver(),super.ngOnDestroy()}onScroll(e){this.showNavigators()&&this.updateButtonState(),e.preventDefault()}onPrevButtonClick(){let e=this.content.nativeElement,i=F(e),n=Math.abs(e.scrollLeft)-i,a=n<=0?0:n;e.scrollLeft=W(e)?-1*a:a}onNextButtonClick(){let e=this.content.nativeElement,i=F(e)-this.getVisibleButtonWidths(),n=e.scrollLeft+i,a=e.scrollWidth-i,o=n>=a?a:n;e.scrollLeft=W(e)?-1*o:o}updateButtonState(){let e=this.content?.nativeElement,i=this.el?.nativeElement,{scrollWidth:n,offsetWidth:a}=e,o=Math.abs(e.scrollLeft),K=F(e);this.isPrevButtonEnabled.set(o!==0),this.isNextButtonEnabled.set(i.offsetWidth>=a&&o!==n-K)}updateInkBar(){let e=this.content.nativeElement,i=this.inkbar.nativeElement,n=this.tabs.nativeElement,a=lt(e,'[data-pc-name="tab"][data-p-active="true"]');i.style.width=rt(a)+"px",i.style.left=q(a).left-q(n).left+"px"}getVisibleButtonWidths(){let e=this.prevButton?.nativeElement,i=this.nextButton?.nativeElement;return[e,i].reduce((n,a)=>a?n+F(a):n,0)}bindResizeObserver(){this.resizeObserver=new ResizeObserver(()=>this.updateButtonState()),this.resizeObserver.observe(this.el.nativeElement)}unbindResizeObserver(){this.resizeObserver&&(this.resizeObserver.unobserve(this.el.nativeElement),this.resizeObserver=null)}static \u0275fac=function(i){return new(i||t)};static \u0275cmp=g({type:t,selectors:[["p-tablist"]],contentQueries:function(i,n,a){if(i&1&&(Q(a,mt,4),Q(a,_t,4),Q(a,ut,4)),i&2){let o;l(o=c())&&(n.prevIconTemplate=o.first),l(o=c())&&(n.nextIconTemplate=o.first),l(o=c())&&(n.templates=o)}},viewQuery:function(i,n){if(i&1&&(x(yt,5),x(Tt,5),x(wt,5),x(xt,5),x(Ct,5)),i&2){let a;l(a=c())&&(n.content=a.first),l(a=c())&&(n.prevButton=a.first),l(a=c())&&(n.nextButton=a.first),l(a=c())&&(n.inkbar=a.first),l(a=c())&&(n.tabs=a.first)}},hostVars:5,hostBindings:function(i,n){i&2&&(r("data-pc-name","tablist"),_("p-tablist",!0)("p-component",!0))},features:[m],ngContentSelectors:E,decls:9,vars:6,consts:[["content",""],["tabs",""],["inkbar",""],["prevButton",""],["nextButton",""],["type","button","pRipple","",1,"p-tablist-nav-button","p-tablist-prev-button"],[1,"p-tablist-content",3,"scroll","ngClass"],["role","tablist",1,"p-tablist-tab-list"],["role","presentation",1,"p-tablist-active-bar"],["type","button","pRipple","",1,"p-tablist-nav-button","p-tablist-next-button"],["type","button","pRipple","",1,"p-tablist-nav-button","p-tablist-prev-button",3,"click"],[4,"ngTemplateOutlet"],["type","button","pRipple","",1,"p-tablist-nav-button","p-tablist-next-button",3,"click"]],template:function(i,n){if(i&1){let a=A();T(),u(0,It,4,4,"button",5),D(1,"div",6,0),I("scroll",function(K){return P(a),V(n.onScroll(K))}),D(3,"div",7,1),w(5),M(6,"span",8,2),S()(),u(8,Pt,4,4,"button",9)}i&2&&(y(n.showNavigators()&&n.isPrevButtonEnabled()?0:-1),v(),O("ngClass",nt(4,kt,n.scrollable())),v(5),r("data-pc-section","inkbar"),v(2),y(n.showNavigators()&&n.isNextButtonEnabled()?8:-1))},dependencies:[k,ot,st,dt,ft,ht,J,G],encapsulation:2,changeDetection:0})}return t})(),Ot=(()=>{class t extends ${value=N();disabled=p(!1,{transform:C});pcTabs=f(B(()=>z));pcTabList=f(B(()=>gt));ripple=s(()=>this.config.ripple());id=s(()=>`${this.pcTabs.id()}_tab_${this.value()}`);ariaControls=s(()=>`${this.pcTabs.id()}_tabpanel_${this.value()}`);active=s(()=>U(this.pcTabs.value(),this.value()));tabindex=s(()=>this.active()?this.pcTabs.tabindex():-1);onFocus(e){this.pcTabs.selectOnFocus()&&this.changeActiveValue()}onClick(e){this.changeActiveValue()}onKeyDown(e){switch(e.code){case"ArrowRight":this.onArrowRightKey(e);break;case"ArrowLeft":this.onArrowLeftKey(e);break;case"Home":this.onHomeKey(e);break;case"End":this.onEndKey(e);break;case"PageDown":this.onPageDownKey(e);break;case"PageUp":this.onPageUpKey(e);break;case"Enter":case"NumpadEnter":case"Space":this.onEnterKey(e);break;default:break}e.stopPropagation()}onArrowRightKey(e){let i=this.findNextTab(e.currentTarget);i?this.changeFocusedTab(e,i):this.onHomeKey(e),e.preventDefault()}onArrowLeftKey(e){let i=this.findPrevTab(e.currentTarget);i?this.changeFocusedTab(e,i):this.onEndKey(e),e.preventDefault()}onHomeKey(e){let i=this.findFirstTab();this.changeFocusedTab(e,i),e.preventDefault()}onEndKey(e){let i=this.findLastTab();this.changeFocusedTab(e,i),e.preventDefault()}onPageDownKey(e){this.scrollInView(this.findLastTab()),e.preventDefault()}onPageUpKey(e){this.scrollInView(this.findFirstTab()),e.preventDefault()}onEnterKey(e){this.changeActiveValue(),e.preventDefault()}findNextTab(e,i=!1){let n=i?e:e.nextElementSibling;return n?L(n,"data-p-disabled")||L(n,"data-pc-section")==="inkbar"?this.findNextTab(n):n:null}findPrevTab(e,i=!1){let n=i?e:e.previousElementSibling;return n?L(n,"data-p-disabled")||L(n,"data-pc-section")==="inkbar"?this.findPrevTab(n):n:null}findFirstTab(){return this.findNextTab(this.pcTabList?.tabs?.nativeElement?.firstElementChild,!0)}findLastTab(){return this.findPrevTab(this.pcTabList?.tabs?.nativeElement?.lastElementChild,!0)}changeActiveValue(){this.pcTabs.updateValue(this.value())}changeFocusedTab(e,i){ct(i),this.scrollInView(i)}scrollInView(e){e?.scrollIntoView?.({block:"nearest"})}static \u0275fac=(()=>{let e;return function(n){return(e||(e=h(t)))(n||t)}})();static \u0275cmp=g({type:t,selectors:[["p-tab"]],hostVars:16,hostBindings:function(i,n){i&1&&I("focus",function(o){return n.onFocus(o)})("click",function(o){return n.onClick(o)})("keydown",function(o){return n.onKeyDown(o)}),i&2&&(r("data-pc-name","tab")("id",n.id())("aria-controls",n.ariaControls())("role","tab")("aria-selected",n.active())("data-p-disabled",n.disabled())("data-p-active",n.active())("tabindex",n.tabindex()),_("p-tab",!0)("p-tab-active",n.active())("p-disabled",n.disabled())("p-component",!0))},inputs:{value:[1,"value"],disabled:[1,"disabled"]},outputs:{value:"valueChange"},features:[tt([J]),m],ngContentSelectors:E,decls:1,vars:0,template:function(i,n){i&1&&(T(),w(0))},dependencies:[k,G],encapsulation:2,changeDetection:0})}return t})(),St=(()=>{class t extends ${pcTabs=f(B(()=>z));value=N(void 0);id=s(()=>`${this.pcTabs.id()}_tabpanel_${this.value()}`);ariaLabelledby=s(()=>`${this.pcTabs.id()}_tab_${this.value()}`);active=s(()=>U(this.pcTabs.value(),this.value()));static \u0275fac=(()=>{let e;return function(n){return(e||(e=h(t)))(n||t)}})();static \u0275cmp=g({type:t,selectors:[["p-tabpanel"]],hostVars:9,hostBindings:function(i,n){i&2&&(r("data-pc-name","tabpanel")("id",n.id())("role","tabpanel")("aria-labelledby",n.ariaLabelledby())("data-p-active",n.active()),_("p-tabpanel",!0)("p-component",!0))},inputs:{value:[1,"value"]},outputs:{value:"valueChange"},features:[m],ngContentSelectors:E,decls:1,vars:1,template:function(i,n){i&1&&(T(),u(0,Vt,1,0)),i&2&&y(n.active()?0:-1)},dependencies:[k],encapsulation:2,changeDetection:0})}return t})(),Mt=(()=>{class t extends ${static \u0275fac=(()=>{let e;return function(n){return(e||(e=h(t)))(n||t)}})();static \u0275cmp=g({type:t,selectors:[["p-tabpanels"]],hostVars:6,hostBindings:function(i,n){i&2&&(r("data-pc-name","tabpanels")("role","presentation"),_("p-tabpanels",!0)("p-component",!0))},features:[m],ngContentSelectors:E,decls:1,vars:0,template:function(i,n){i&1&&(T(),w(0))},dependencies:[k],encapsulation:2,changeDetection:0})}return t})(),z=(()=>{class t extends ${value=N(void 0);scrollable=p(!1,{transform:C});lazy=p(!1,{transform:C});selectOnFocus=p(!1,{transform:C});showNavigators=p(!0,{transform:C});tabindex=p(0,{transform:it});id=R(bt("pn_id_"));_componentStyle=f(vt);updateValue(e){this.value.update(()=>e)}static \u0275fac=(()=>{let e;return function(n){return(e||(e=h(t)))(n||t)}})();static \u0275cmp=g({type:t,selectors:[["p-tabs"]],hostVars:8,hostBindings:function(i,n){i&2&&(r("data-pc-name","tabs")("id",n.id),_("p-tabs",!0)("p-tabs-scrollable",n.scrollable())("p-component",!0))},inputs:{value:[1,"value"],scrollable:[1,"scrollable"],lazy:[1,"lazy"],selectOnFocus:[1,"selectOnFocus"],showNavigators:[1,"showNavigators"],tabindex:[1,"tabindex"]},outputs:{value:"valueChange"},features:[et([vt]),m],ngContentSelectors:E,decls:1,vars:0,template:function(i,n){i&1&&(T(),w(0))},dependencies:[k],encapsulation:2,changeDetection:0})}return t})(),re=(()=>{class t{static \u0275fac=function(i){return new(i||t)};static \u0275mod=Z({type:t});static \u0275inj=Y({imports:[z,Mt,St,gt,Ot]})}return t})();export{gt as a,Ot as b,St as c,Mt as d,z as e,re as f};
