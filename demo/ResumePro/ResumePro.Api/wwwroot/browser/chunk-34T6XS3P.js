import{a as l}from"./chunk-VFFTA6WI.js";import"./chunk-Y6HZP4KD.js";import{a as c}from"./chunk-RSYUMYAF.js";import"./chunk-AL4XRLEA.js";import"./chunk-K4SGUUR5.js";import"./chunk-COXNR3KN.js";import"./chunk-NMHADN5P.js";import"./chunk-IENZGI3C.js";import"./chunk-KZO2A2S5.js";import"./chunk-5QABPFLC.js";import"./chunk-UDQJOS2S.js";import"./chunk-BQWXN4DA.js";import"./chunk-OBQOVGLQ.js";import"./chunk-IGU7SFJN.js";import"./chunk-LAKTUHSI.js";import"./chunk-SGUPKBVV.js";import"./chunk-P63N2URC.js";import"./chunk-2AJWNTIY.js";import"./chunk-SLHJZJNW.js";import"./chunk-WNUESBZL.js";import"./chunk-JJQLEQOL.js";import"./chunk-BIL3QBLO.js";import"./chunk-THVSKX6G.js";import"./chunk-MLPLYTXL.js";import"./chunk-DUGBXOMB.js";import"./chunk-RO6F6Z3R.js";import"./chunk-AGR62YLL.js";import"./chunk-LAJDMLHM.js";import"./chunk-MEZEMTYB.js";import"./chunk-SMJIQ4E4.js";import"./chunk-YUUY53IN.js";import"./chunk-3BQEJCHT.js";import"./chunk-BDXJXXVS.js";import"./chunk-5ITMLF3G.js";import"./chunk-BODZH67C.js";import"./chunk-QXZQXA5D.js";import"./chunk-TI2YGS5M.js";import"./chunk-WCGJ44IN.js";import"./chunk-ZHGKNXMS.js";import{Ua as n,ab as o,ob as r,zb as a}from"./chunk-DKCBYRU7.js";import"./chunk-GAL4ENT6.js";var f=(()=>{class e{mailService;trashMails=[];subscription;constructor(t){this.mailService=t,this.subscription=this.mailService.mails$.subscribe(i=>{this.trashMails=i.filter(s=>s.trash)})}ngOnDestroy(){this.subscription.unsubscribe()}static \u0275fac=function(i){return new(i||e)(n(c))};static \u0275cmp=o({type:e,selectors:[["ng-component"]],decls:1,vars:1,consts:[[3,"mails"]],template:function(i,s){i&1&&a(0,"app-mail-table",0),i&2&&r("mails",s.trashMails)},dependencies:[l],encapsulation:2})}return e})();export{f as MailTrashComponent};
