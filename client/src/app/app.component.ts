import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { TableDataOptions } from './models/table-options.model';
import { BlogReportService } from './services/blog-report.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  reportData = [];
  search = "";
  @ViewChild("paginator") MatP: MatPaginator;
  constructor(private blogReportService: BlogReportService) {

  }

  ngOnInit() {
    this.blogReportService.get(new TableDataOptions()).subscribe(e => {
      console.log(e);
      if (e)
        this.reportData = e;
    })
  }
  applyFilter(event) {

  }
  getLike(com) {
    if (com) {
      return com.filter(e => e.isLike).length;
    }
  }
  getDislike(com) {
    if (com) {
      return com.filter(e => !e.isLike).length;
    }
  }
  getTableData(pageSize: number, event?: any) {
    let tableDataOptions = new TableDataOptions();
    if (this.isNextClick(event)) {
      if (this.checkIfTableHasData()) {
        if (this.MatP.pageSize) {
          pageSize = this.MatP.pageSize;
        }
        tableDataOptions.take = this.getNumberOfRowToTake(pageSize, event);
        tableDataOptions.skip = this.reportData.length;
        this.blogReportService.get(tableDataOptions).subscribe((res: any) => {
          if (res) {
            console.log(res)
            this.reportData = this.reportData.concat(res);
          }
        })
      }
    }
    return new Promise(e => { return e(undefined) });
  }
  getNumberOfRowToTake(pageSize: number, event: any) {
    if (event && event.pageIndex > event.previousPageIndex && (event.pageIndex - event.previousPageIndex) != 1) {
      let currentRowCount = (event.previousPageIndex + 1) * pageSize;
      return event.length - currentRowCount;
    }
    return pageSize;
  }
  totalRowCount = 4;
  checkIfTableHasData() {
    if (this.totalRowCount > 0) {
      let dataLength = this.reportData.length;
      if (this.totalRowCount > dataLength) {
        return true;
      }
      else
        return false;
    }
    return true;
  }
  isNextClick(event: any) {
    if (event) {
      return !event || !(event.previousPageIndex > event.pageIndex);
    }
    return true;
  }
  onInput(){

  }
}
