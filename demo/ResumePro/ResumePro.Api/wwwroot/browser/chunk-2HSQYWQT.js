import{e as ae,f as le}from"./chunk-QXZQXA5D.js";import"./chunk-TI2YGS5M.js";import{Aa as P,Da as H,Y as te,qa as ie,ra as ne,sa as N,ta as b}from"./chunk-ZHGKNXMS.js";import{Ab as D,Bb as F,Cb as h,Gb as _,Hb as W,Ib as B,Jc as Y,Kb as u,Kc as Z,La as J,Lc as $,Mb as f,Nb as v,Oc as ee,Pa as a,Pc as A,Q as w,Qb as X,R as Q,Rb as s,Sb as M,Tb as T,Uc as I,W as z,Yb as j,_b as S,ab as k,bb as R,ea as C,eb as O,gb as c,mc as g,nb as y,ob as o,pa as G,qb as K,rb as q,sb as E,xb as l,yb as r,zb as x}from"./chunk-DKCBYRU7.js";import"./chunk-GAL4ENT6.js";var de=["content"],ue=["opposite"],fe=["marker"],V=e=>({$implicit:e});function ve(e,n){e&1&&h(0)}function ge(e,n){e&1&&h(0)}function _e(e,n){if(e&1&&(D(0),c(1,ge,1,0,"ng-container",4),F()),e&2){let t=_().$implicit,p=_();a(),o("ngTemplateOutlet",p.markerTemplate||p._markerTemplate)("ngTemplateOutletContext",S(2,V,t))}}function he(e,n){e&1&&x(0,"div",9),e&2&&y("data-pc-section","marker")}function ye(e,n){e&1&&x(0,"div",10)}function Te(e,n){e&1&&h(0)}function be(e,n){if(e&1&&(l(0,"div",2)(1,"div",3),c(2,ve,1,0,"ng-container",4),r(),l(3,"div",5),c(4,_e,2,4,"ng-container",6)(5,he,1,1,"ng-template",null,0,g)(7,ye,1,0,"div",7),r(),l(8,"div",8),c(9,Te,1,0,"ng-container",4),r()()),e&2){let t=n.$implicit,p=n.last,i=X(6),d=_();y("data-pc-section","event"),a(),y("data-pc-section","opposite"),a(),o("ngTemplateOutlet",d.oppositeTemplate||d._oppositeTemplate)("ngTemplateOutletContext",S(11,V,t)),a(),y("data-pc-section","separator"),a(),o("ngIf",d.markerTemplate||d._markerTemplate)("ngIfElse",i),a(3),o("ngIf",!p),a(),y("data-pc-section","content"),a(),o("ngTemplateOutlet",d.contentTemplate||d._contentTemplate)("ngTemplateOutletContext",S(13,V,t))}}var xe=({dt:e})=>`
.p-timeline {
    display: flex;
    flex-grow: 1;
    flex-direction: column;
    direction: ltr;
}

.p-timeline-left .p-timeline-event-opposite {
    text-align: right;
}

.p-timeline-left .p-timeline-event-content {
    text-align: left;
}

.p-timeline-right .p-timeline-event {
    flex-direction: row-reverse;
}

.p-timeline-right .p-timeline-event-opposite {
    text-align: left;
}

.p-timeline-right .p-timeline-event-content {
    text-align: right;
}

.p-timeline-vertical.p-timeline-alternate .p-timeline-event:nth-child(even) {
    flex-direction: row-reverse;
}

.p-timeline-vertical.p-timeline-alternate .p-timeline-event:nth-child(odd) .p-timeline-event-opposite {
    text-align: right;
}

.p-timeline-vertical.p-timeline-alternate .p-timeline-event:nth-child(odd) .p-timeline-event-content {
    text-align: left;
}

.p-timeline-vertical.p-timeline-alternate .p-timeline-event:nth-child(even) .p-timeline-event-opposite {
    text-align: left;
}

.p-timeline-vertical.p-timeline-alternate .p-timeline-event:nth-child(even) .p-timeline-event-content {
    text-align: right;
}

.p-timeline-vertical .p-timeline-event-opposite,
.p-timeline-vertical .p-timeline-event-content {
    padding: ${e("timeline.vertical.event.content.padding")};
}

.p-timeline-vertical .p-timeline-event-connector {
    width: ${e("timeline.event.connector.size")};
}

.p-timeline-event {
    display: flex;
    position: relative;
    min-height: ${e("timeline.event.min.height")};
}

.p-timeline-event:last-child {
    min-height: 0;
}

.p-timeline-event-opposite {
    flex: 1;
}

.p-timeline-event-content {
    flex: 1;
}

.p-timeline-event-separator {
    flex: 0;
    display: flex;
    align-items: center;
    flex-direction: column;
}

.p-timeline-event-marker {
    display: inline-flex;
    align-items: center;
    justify-content: center;
    position: relative;
    align-self: baseline;
    border-width: ${e("timeline.event.marker.border.width")};
    border-style: solid;
    border-color: ${e("timeline.event.marker.border.color")};
    border-radius: ${e("timeline.event.marker.border.radius")};
    width: ${e("timeline.event.marker.size")};
    height: ${e("timeline.event.marker.size")};
    background: ${e("timeline.event.marker.background")};
}

.p-timeline-event-marker::before {
    content: " ";
    border-radius: ${e("timeline.event.marker.content.border.radius")};
    width: ${e("timeline.event.marker.content.size")};
    height:${e("timeline.event.marker.content.size")};
    background: ${e("timeline.event.marker.content.background")};
}

.p-timeline-event-marker::after {
    content: " ";
    position: absolute;
    width: 100%;
    height: 100%;
    border-radius: ${e("timeline.event.marker.border.radius")};
    box-shadow: ${e("timeline.event.marker.content.inset.shadow")};
}

.p-timeline-event-connector {
    flex-grow: 1;
    background: ${e("timeline.event.connector.color")};
}

.p-timeline-horizontal {
    flex-direction: row;
}

.p-timeline-horizontal .p-timeline-event {
    flex-direction: column;
    flex: 1;
}

.p-timeline-horizontal .p-timeline-event:last-child {
    flex: 0;
}

.p-timeline-horizontal .p-timeline-event-separator {
    flex-direction: row;
}

.p-timeline-horizontal .p-timeline-event-connector {
    width: 100%;
    height: ${e("timeline.event.connector.size")};
}

.p-timeline-horizontal .p-timeline-event-opposite,
.p-timeline-horizontal .p-timeline-event-content {
    padding: ${e("timeline.horizontal.event.content.padding")};
}

.p-timeline-horizontal.p-timeline-alternate .p-timeline-event:nth-child(even) {
    flex-direction: column-reverse;
}

.p-timeline-bottom .p-timeline-event {
    flex-direction: column-reverse;
}
`,Ce={root:({props:e})=>["p-timeline p-component","p-timeline-"+e.align,"p-timeline-"+e.layout],event:"p-timeline-event",eventOpposite:"p-timeline-event-opposite",eventSeparator:"p-timeline-event-separator",eventMarker:"p-timeline-event-marker",eventConnector:"p-timeline-event-connector",eventContent:"p-timeline-event-content"},oe=(()=>{class e extends P{name="timeline";theme=xe;classes=Ce;static \u0275fac=(()=>{let t;return function(i){return(t||(t=C(e)))(i||e)}})();static \u0275prov=w({token:e,factory:e.\u0275fac})}return e})();var L=(()=>{class e extends H{value;style;styleClass;align="left";layout="vertical";contentTemplate;oppositeTemplate;markerTemplate;templates;_contentTemplate;_oppositeTemplate;_markerTemplate;_componentStyle=z(oe);get hostClass(){return this.styleClass}getBlockableElement(){return this.el.nativeElement.children[0]}ngAfterContentInit(){this.templates.forEach(t=>{switch(t.getType()){case"content":this._contentTemplate=t.template;break;case"opposite":this._oppositeTemplate=t.template;break;case"marker":this._markerTemplate=t.template;break}})}static \u0275fac=(()=>{let t;return function(i){return(t||(t=C(e)))(i||e)}})();static \u0275cmp=k({type:e,selectors:[["p-timeline"]],contentQueries:function(p,i,d){if(p&1&&(u(d,de,4),u(d,ue,4),u(d,fe,4),u(d,N,4)),p&2){let m;f(m=v())&&(i.contentTemplate=m.first),f(m=v())&&(i.oppositeTemplate=m.first),f(m=v())&&(i.markerTemplate=m.first),f(m=v())&&(i.templates=m)}},hostVars:24,hostBindings:function(p,i){p&2&&(y("data-pc-section","root")("data-pc-name","timeline"),q(i.style),E(i.hostClass),K("p-timeline",!0)("p-component",!0)("p-timeline-left",i.align==="left")("p-timeline-right",i.align==="right")("p-timeline-top",i.align==="top")("p-timeline-bottom",i.align==="bottom")("p-timeline-alternate",i.align==="alternate")("p-timeline-vertical",i.layout==="vertical")("p-timeline-horizontal",i.layout==="horizontal"))},inputs:{value:"value",style:"style",styleClass:"styleClass",align:"align",layout:"layout"},features:[j([oe]),O],decls:1,vars:1,consts:[["marker",""],["class","p-timeline-event",4,"ngFor","ngForOf"],[1,"p-timeline-event"],[1,"p-timeline-event-opposite"],[4,"ngTemplateOutlet","ngTemplateOutletContext"],[1,"p-timeline-event-separator"],[4,"ngIf","ngIfElse"],["class","p-timeline-event-connector",4,"ngIf"],[1,"p-timeline-event-content"],[1,"p-timeline-event-marker"],[1,"p-timeline-event-connector"]],template:function(p,i){p&1&&c(0,be,10,15,"div",1),p&2&&o("ngForOf",i.value)},dependencies:[I,Z,$,A,b],encapsulation:2,changeDetection:0})}return e})(),me=(()=>{class e{static \u0275fac=function(p){return new(p||e)};static \u0275mod=R({type:e});static \u0275inj=Q({imports:[L,b,b]})}return e})();var Ee=["header"],Se=["title"],$e=["subtitle"],Ie=["content"],De=["footer"],Fe=["*",[["p-header"]],[["p-footer"]]],Me=["*","p-header","p-footer"];function we(e,n){e&1&&h(0)}function Qe(e,n){if(e&1&&(l(0,"div",8),B(1,1),c(2,we,1,0,"ng-container",6),r()),e&2){let t=_();a(2),o("ngTemplateOutlet",t.headerTemplate||t._headerTemplate)}}function ze(e,n){if(e&1&&(D(0),s(1),F()),e&2){let t=_(2);a(),M(t.header)}}function Re(e,n){e&1&&h(0)}function Oe(e,n){if(e&1&&(l(0,"div",9),c(1,ze,2,1,"ng-container",10)(2,Re,1,0,"ng-container",6),r()),e&2){let t=_();a(),o("ngIf",t.header&&!t._titleTemplate&&!t.titleTemplate),a(),o("ngTemplateOutlet",t.titleTemplate||t._titleTemplate)}}function qe(e,n){if(e&1&&(D(0),s(1),F()),e&2){let t=_(2);a(),M(t.subheader)}}function Be(e,n){e&1&&h(0)}function je(e,n){if(e&1&&(l(0,"div",11),c(1,qe,2,1,"ng-container",10)(2,Be,1,0,"ng-container",6),r()),e&2){let t=_();a(),o("ngIf",t.subheader&&!t._subtitleTemplate&&!t.subtitleTemplate),a(),o("ngTemplateOutlet",t.subtitleTemplate||t._subtitleTemplate)}}function Ae(e,n){e&1&&h(0)}function Ne(e,n){e&1&&h(0)}function Pe(e,n){if(e&1&&(l(0,"div",12),B(1,2),c(2,Ne,1,0,"ng-container",6),r()),e&2){let t=_();a(2),o("ngTemplateOutlet",t.footerTemplate||t._footerTemplate)}}var He=({dt:e})=>`
.p-card {
    background: ${e("card.background")};
    color: ${e("card.color")};
    box-shadow: ${e("card.shadow")};
    border-radius: ${e("card.border.radius")};
    display: flex;
    flex-direction: column;
}

.p-card-caption {
    display: flex;
    flex-direction: column;
    gap: ${e("card.caption.gap")};
}

.p-card-body {
    padding: ${e("card.body.padding")};
    display: flex;
    flex-direction: column;
    gap: ${e("card.body.gap")};
}

.p-card-title {
    font-size: ${e("card.title.font.size")};
    font-weight: ${e("card.title.font.weight")};
}

.p-card-subtitle {
    color: ${e("card.subtitle.color")};
}
`,Ve={root:"p-card p-component",header:"p-card-header",body:"p-card-body",caption:"p-card-caption",title:"p-card-title",subtitle:"p-card-subtitle",content:"p-card-content",footer:"p-card-footer"},ce=(()=>{class e extends P{name="card";theme=He;classes=Ve;static \u0275fac=(()=>{let t;return function(i){return(t||(t=C(e)))(i||e)}})();static \u0275prov=w({token:e,factory:e.\u0275fac})}return e})();var U=(()=>{class e extends H{header;subheader;set style(t){te(this._style(),t)||this._style.set(t)}styleClass;headerFacet;footerFacet;headerTemplate;titleTemplate;subtitleTemplate;contentTemplate;footerTemplate;_headerTemplate;_titleTemplate;_subtitleTemplate;_contentTemplate;_footerTemplate;_style=G(null);_componentStyle=z(ce);getBlockableElement(){return this.el.nativeElement.children[0]}templates;ngAfterContentInit(){this.templates.forEach(t=>{switch(t.getType()){case"header":this._headerTemplate=t.template;break;case"title":this._titleTemplate=t.template;break;case"subtitle":this._subtitleTemplate=t.template;break;case"content":this._contentTemplate=t.template;break;case"footer":this._footerTemplate=t.template;break;default:this._contentTemplate=t.template;break}})}static \u0275fac=(()=>{let t;return function(i){return(t||(t=C(e)))(i||e)}})();static \u0275cmp=k({type:e,selectors:[["p-card"]],contentQueries:function(p,i,d){if(p&1&&(u(d,ie,5),u(d,ne,5),u(d,Ee,4),u(d,Se,4),u(d,$e,4),u(d,Ie,4),u(d,De,4),u(d,N,4)),p&2){let m;f(m=v())&&(i.headerFacet=m.first),f(m=v())&&(i.footerFacet=m.first),f(m=v())&&(i.headerTemplate=m.first),f(m=v())&&(i.titleTemplate=m.first),f(m=v())&&(i.subtitleTemplate=m.first),f(m=v())&&(i.contentTemplate=m.first),f(m=v())&&(i.footerTemplate=m.first),f(m=v())&&(i.templates=m)}},inputs:{header:"header",subheader:"subheader",style:"style",styleClass:"styleClass"},features:[j([ce]),O],ngContentSelectors:Me,decls:9,vars:10,consts:[[3,"ngClass","ngStyle"],["class","p-card-header",4,"ngIf"],[1,"p-card-body"],["class","p-card-title",4,"ngIf"],["class","p-card-subtitle",4,"ngIf"],[1,"p-card-content"],[4,"ngTemplateOutlet"],["class","p-card-footer",4,"ngIf"],[1,"p-card-header"],[1,"p-card-title"],[4,"ngIf"],[1,"p-card-subtitle"],[1,"p-card-footer"]],template:function(p,i){p&1&&(W(Fe),l(0,"div",0),c(1,Qe,3,1,"div",1),l(2,"div",2),c(3,Oe,3,2,"div",3)(4,je,3,2,"div",4),l(5,"div",5),B(6),c(7,Ae,1,0,"ng-container",6),r(),c(8,Pe,3,1,"div",7),r()()),p&2&&(E(i.styleClass),o("ngClass","p-card p-component")("ngStyle",i._style()),y("data-pc-name","card"),a(),o("ngIf",i.headerFacet||i.headerTemplate||i._headerTemplate),a(2),o("ngIf",i.header||i.titleTemplate||i._titleTemplate),a(),o("ngIf",i.subheader||i.subtitleTemplate||i._subtitleTemplate),a(3),o("ngTemplateOutlet",i.contentTemplate||i._contentTemplate),a(),o("ngIf",i.footerFacet||i.footerTemplate||i._footerTemplate))},dependencies:[I,Y,$,A,ee,b],encapsulation:2,changeDetection:0})}return e})(),se=(()=>{class e{static \u0275fac=function(p){return new(p||e)};static \u0275mod=R({type:e});static \u0275inj=Q({imports:[U,b,b]})}return e})();var Ue=e=>({"background-color":e});function Ge(e,n){if(e&1&&s(0),e&2){let t=n.$implicit;T(" ",t.status," ")}}function Je(e,n){if(e&1&&s(0),e&2){let t=n.$implicit;T(" ",t.status," ")}}function Ke(e,n){if(e&1&&s(0),e&2){let t=n.$implicit;T(" ",t.status," ")}}function We(e,n){if(e&1&&(l(0,"small",17),s(1),r()),e&2){let t=n.$implicit;a(),M(t.date)}}function Xe(e,n){if(e&1&&s(0),e&2){let t=n.$implicit;T(" ",t.status," ")}}function Ye(e,n){if(e&1&&(l(0,"span",18),x(1,"i"),r()),e&2){let t=n.$implicit;q(S(4,Ue,t.color)),a(),E(t.icon)}}function Ze(e,n){if(e&1&&x(0,"img",22),e&2){let t=_().$implicit;o("src","/demo/images/product/"+t.image,J)("alt",t.name)}}function et(e,n){if(e&1&&(l(0,"p-card",19),c(1,Ze,1,2,"img",20),l(2,"p"),s(3," Lorem ipsum dolor sit amet, consectetur adipisicing elit. Inventore sed consequuntur error repudiandae numquam deserunt quisquam repellat libero asperiores earum nam nobis, culpa ratione quam perferendis esse, cupiditate neque quas! "),r(),x(4,"p-button",21),r()),e&2){let t=n.$implicit;o("header",t.status)("subheader",t.date),a(),o("ngIf",t.image),a(3),o("text",!0)}}function tt(e,n){if(e&1&&s(0),e&2){let t=n.$implicit;T(" ",t," ")}}function it(e,n){if(e&1&&s(0),e&2){let t=n.$implicit;T(" ",t," ")}}function nt(e,n){if(e&1&&s(0),e&2){let t=n.$implicit;T(" ",t," ")}}function at(e,n){e&1&&s(0," \xA0 ")}var Bt=(()=>{class e{events1=[];events2=[];ngOnInit(){this.events1=[{status:"Ordered",date:"15/10/2020 10:30",icon:"pi pi-shopping-cart",color:"#9C27B0",image:"game-controller.jpg"},{status:"Processing",date:"15/10/2020 14:00",icon:"pi pi-cog",color:"#673AB7"},{status:"Shipped",date:"15/10/2020 16:15",icon:"pi pi-envelope",color:"#FF9800"},{status:"Delivered",date:"16/10/2020 10:00",icon:"pi pi-check",color:"#607D8B"}],this.events2=["2020","2021","2022","2023"]}static \u0275fac=function(p){return new(p||e)};static \u0275cmp=k({type:e,selectors:[["app-timeline-demo"]],decls:61,vars:8,consts:[["content",""],["opposite",""],["marker",""],[1,"grid","grid-cols-12","gap-8"],[1,"col-span-6"],[1,"card"],[1,"font-semibold","text-xl","mb-4"],[3,"value"],["align","right",3,"value"],["align","alternate",3,"value"],[1,"col-span-full"],["align","alternate","styleClass","customized-timeline",3,"value"],[1,"font-semibold","mb-2"],["layout","horizontal","align","top",3,"value"],[1,"font-semibold","mt-4","mb-2"],["layout","horizontal","align","bottom",3,"value"],["layout","horizontal","align","alternate",3,"value"],[1,"p-text-secondary"],[1,"flex","w-8","h-8","items-center","justify-center","text-white","rounded-full","z-10","shadow-sm"],[3,"header","subheader"],["width","200","class","shadow",3,"src","alt",4,"ngIf"],["label","Read more",3,"text"],["width","200",1,"shadow",3,"src","alt"]],template:function(p,i){p&1&&(l(0,"div",3)(1,"div",4)(2,"div",5)(3,"div",6),s(4,"Left Align"),r(),l(5,"p-timeline",7),c(6,Ge,1,1,"ng-template",null,0,g),r()()(),l(8,"div",4)(9,"div",5)(10,"div",6),s(11,"Right Align"),r(),l(12,"p-timeline",8),c(13,Je,1,1,"ng-template",null,0,g),r()()(),l(15,"div",4)(16,"div",5)(17,"div",6),s(18,"Alternate Align"),r(),l(19,"p-timeline",9),c(20,Ke,1,1,"ng-template",null,0,g),r()()(),l(22,"div",4)(23,"div",5)(24,"div",6),s(25,"Opposite Content"),r(),l(26,"p-timeline",7),c(27,We,2,1,"ng-template",null,0,g)(29,Xe,1,1,"ng-template",null,1,g),r()()(),l(31,"div",10)(32,"div",5)(33,"div",6),s(34,"Templating"),r(),l(35,"p-timeline",11),c(36,Ye,2,6,"ng-template",null,2,g)(38,et,5,4,"ng-template",null,0,g),r()()(),l(40,"div",10)(41,"div",5)(42,"div",6),s(43,"Horizontal"),r(),l(44,"div",12),s(45,"Top Align"),r(),l(46,"p-timeline",13),c(47,tt,1,1,"ng-template",null,0,g),r(),l(49,"div",14),s(50,"Bottom Align"),r(),l(51,"p-timeline",15),c(52,it,1,1,"ng-template",null,0,g),r(),l(54,"div",14),s(55,"Alternate Align"),r(),l(56,"p-timeline",16),c(57,nt,1,1,"ng-template",null,0,g)(59,at,1,0,"ng-template",null,1,g),r()()()()),p&2&&(a(5),o("value",i.events1),a(7),o("value",i.events1),a(7),o("value",i.events1),a(7),o("value",i.events1),a(9),o("value",i.events1),a(11),o("value",i.events2),a(5),o("value",i.events2),a(5),o("value",i.events2))},dependencies:[I,$,me,L,le,ae,se,U],encapsulation:2})}return e})();export{Bt as TimelineDemo};
