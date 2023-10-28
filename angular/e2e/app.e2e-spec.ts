import { OrnekProjeTemplatePage } from './app.po';

describe('OrnekProje App', function() {
  let page: OrnekProjeTemplatePage;

  beforeEach(() => {
    page = new OrnekProjeTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
